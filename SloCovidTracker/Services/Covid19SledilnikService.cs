using System.Globalization;
using SloCovidTracker.Models.Covid19Sledilnik;
using System.Net.Http;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace SloCovidTracker.Services;

public class Covid19SledilnikService
{
    private readonly IHttpClientFactory _httpClientFactory;
    
    private const string ExternalDataSourceUrl = "https://raw.githubusercontent.com/sledilnik/data/master/csv/region-cases.csv";

    public Covid19SledilnikService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    /// <summary>
    /// Get data from Covid19Sledilnik page
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<DailyCases>> GetData()
    {
        var client = _httpClientFactory.CreateClient();

        var response = await client.GetAsync(ExternalDataSourceUrl);

        if (response.IsSuccessStatusCode)
        {
            using var stream = await response.Content.ReadAsStreamAsync();
            using var reader = new StreamReader(stream);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ",", Encoding = Encoding.UTF8 });
            
            var cases = csv.GetRecords<DailyCases>().ToList();

            return cases;
        }

        // missing a Result type or something similar to return an error and an empty list or null
        return Enumerable.Empty<DailyCases>();
    }
}