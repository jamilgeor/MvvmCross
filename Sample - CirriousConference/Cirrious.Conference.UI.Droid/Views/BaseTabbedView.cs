using Android.Views;
using Cirrious.Conference.Core.ViewModels;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.Interfaces.ViewModels;

namespace Cirrious.Conference.UI.Droid.Views
{
    public abstract class BaseTabbedView<TViewModel> 
        : MvxBindingTabActivityView<TViewModel>
        , IBaseView<TViewModel>
        where TViewModel : BaseViewModel
    {
        protected override void OnCreate(Android.OS.Bundle bundle)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);

            base.OnCreate(bundle);

            var drawable = Resources.GetDrawable(Resource.Drawable.background);
            drawable.SetDither(true);
            Window.SetBackgroundDrawable(drawable);
        }
    }
}