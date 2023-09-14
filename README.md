# SloCovidTracker
This project exposes covid data from covid-19-sledilnik.org page.

This project uses .NET Core 6.0, CsvHelper 30.0.1 and System.Net.Http.Json 6.0.0

The server exposes two api endpoints:
- GET /api/region/cases
  
  This endpoint returns a list of daily active cases, number of vaccinated 1st and 2nd time, and number of deceased to date.
  This endpoint supports three optional query parameters:
  
      - region: a comma separated list of regions; for example: "LJ,KR". The supported regions are LJ, CE, KR, NM, KK, KP, MB, MS, NG, PO, SG, ZA.
  
      - from: from date in format yyyy-MM-dd; for example: 2020-01-02
  
      - to: to date in format yyyy-MM-dd; for example: 2020-01-03

  The endpoint returns a list of DailyCasesByRegion objects:
  ```
    [{
      date: string(yyyy-MM-dd)
      region: string 
      nrActiveCases: int
      nrVaccinated1St: int
      nrVaccinated2Nd: int
      nrDeceasedToDate: int
    }]
  ```  
  Example:
  ```
    [{
      date: "2020-02-01"
      region: "LJ"
      nrActiveCases: 203
      nrVaccinated1St: 5000
      nrVaccinated2Nd: 2500
      nrDeceasedToDate: 1000
    }, ...]
  ```

  The endpoint returns an empty list if an error occured.

- GET /api/region/lastweek

  This endpoint returns average daily cases of the last 7 days for each region.
  This endpoint has no query parameters.
  The endpoint returns a list of CasesLastWeek objects:
  ```
  [{
    region : string
    nrCases : double
  }]
  ```
  Example:
  ```
  [{
    "region": "LJ",
    "nrCases": 1209.3333333333333
  },
  {
    "region": "MB",
    "nrCases": 991.6666666666666
  }, ...]
  ```

  The endpoint returns an empty list if an error occured.



  A swagger server is provided and is started up on port 7282, once the app is running. You may test the api through it.
