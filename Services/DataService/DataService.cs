using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Services.DataService
{
    /// <summary>
    /// https://api.fbi.gov/docs#/
    /// </summary>
    public class DataService : IDataService
    {
        public DataService()
        {
        }

        public async Task GetFullList(int page)
        {
            throw new NotImplementedException();
        }
    }
}
