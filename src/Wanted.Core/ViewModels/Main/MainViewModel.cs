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

        private string _imageURL;
        public string ImageURL
        {
            get => _imageURL;
            set => SetProperty(ref _imageURL, value, nameof(ImageURL));
        }

        private Person _wantedPerson;
        public Person WantedPerson
        {
            get => _wantedPerson;
            set => SetProperty(ref _wantedPerson, value, nameof(WantedPerson));
        }

        public override async Task Initialize()
        {
            var wantedList = await _dataService.GetFullList(0);
            WantedPerson = wantedList[0];
            NameText = wantedList[0].title;
            HeaderText = wantedList[0].reward_text;
            //ImageURL = wantedList[0].images[0];
            await RaiseAllPropertiesChanged();

        }

        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _headerText = "Wanted:";
        }
    }
}
