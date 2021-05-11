using Foundation;
using MvvmCross.Platforms.Ios.Core;
using Wanted.Core;

namespace Wanted.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
