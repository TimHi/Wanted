using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.DataService;
using Services.DataService.FBIAPI.Model;

namespace Wanted.Core.ViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IDataService _dataService;
        
        private string _nameText;
        public string NameText
        {
            get => _nameText;
            set => SetProperty(ref _nameText, value, nameof(NameText));
        }

        private string _headerText;
        public string HeaderText
        {
            get => _headerText; 
            set => SetProperty(ref _headerText, value, nameof(HeaderText)); 
        }

        private Person _wantedPerson;
        public Person WantedPerson
        {
            get => _wantedPerson;
            set => SetProperty(ref _wantedPerson, value, nameof(WantedPerson));
        }

        public override async Task Initialize()
        {
            await _dataService.GetFullList(0);
        }

        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _headerText = "Wanted:";
            _wantedPerson = new Person("Schwein", "Peter", @"https://d2k62v4a641q9c.cloudfront.net/media/image/78/2e/5b/PS2021_Sport1_Irokesenschwein_Lila_2021_1.png", "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.");
            _nameText = _wantedPerson.FirstName + " " + _wantedPerson.LastName;
        }
    }
}
