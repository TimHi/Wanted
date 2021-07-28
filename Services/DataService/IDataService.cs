using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Services.DataService.FBIAPI.Model;

namespace Services.DataService
{
    public interface IDataService
    {
        Task<List<Person>> GetFullList(int page);
    }
}
