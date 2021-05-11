using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Wanted.Core.ViewModels.Main;

namespace Wanted.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
