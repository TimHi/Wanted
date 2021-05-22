using System;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Binding.BindingContext;
using UIKit;
using Wanted.Core.ViewModels.Main;
using Wanted.iOS.Converter;

namespace Wanted.iOS.Views.Main
{
    public partial class MainView : MvxViewController<MainViewModel>
    {
        public MainView() : base("MainView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationController.NavigationBarHidden = true;
            CreateBindings();
        }

        private void CreateBindings()
        {
            MvxFluentBindingDescriptionSet<MainView, MainViewModel> bindingSet = this.CreateBindingSet<MainView, MainViewModel>();

            bindingSet.Bind(Name).For(v => v.Text).To(vm => vm.NameText);
            bindingSet.Bind(Header).For(v => v.Text).To(vm => vm.HeaderText);
            bindingSet.Bind(Description).For(v => v.Text).To(vm => vm.WantedPerson.DescriptionText);
            bindingSet.Bind(Image).For(v => v.Image).To(vm => vm.WantedPerson.ImageURL).WithConversion(new StringToImageConverter());

            bindingSet.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

