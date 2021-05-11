using MvvmCross;
using MvvmCross.Platforms.Ios.Core;
using Services.DataService;
using Wanted.Core;

namespace Wanted.iOS
{
    public class Setup : MvxIosSetup<App>
    {

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();
            Mvx.IoCProvider.RegisterSingleton<IDataService>(new DataService());
        }
    }
}
