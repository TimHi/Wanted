using System;
using System.Threading.Tasks;

namespace Services.DataService
{
    public interface IDataService
    {
        Task GetFullList(int page);
    }
}
