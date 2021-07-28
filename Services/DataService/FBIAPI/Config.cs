using System;
namespace Services.DataService.FBIAPI
{
    public static class Config
    {
        public static string BaseURL = @"https://api.fbi.gov/";

        public static string WantedEndpoint = @"wanted?pageSize=20&page=1&sort_on=modified&sort_order=desc";
    }
}
