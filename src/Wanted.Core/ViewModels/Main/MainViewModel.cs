using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.DataService;

namespace Wanted.Core.ViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IDataService dataService;
        public MainViewModel(IDataService dataService)
        {
            this.dataService = dataService;
        }
    }
}
