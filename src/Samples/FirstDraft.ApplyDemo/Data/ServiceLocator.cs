using FirstDraft.ApplyDemo.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace FirstDraft.ApplyDemo.Data
{
    internal class ServiceLocator
    {
        public MainWindowModel MainWindowModel => App.Current.Services.GetService<MainWindowModel>();
        public ApplyIconButtonViewModel ButtonViewModel => App.Current.Services.GetService<ApplyIconButtonViewModel>();
        public WelcomeViewModel WelcomeViewModel => App.Current.Services.GetService<WelcomeViewModel>();
        public IconSetViewModel IconSetViewModel => App.Current.Services.GetService<IconSetViewModel>();
        public ApplyComboBoxViewModel ApplyComboBoxViewModel => App.Current.Services.GetService<ApplyComboBoxViewModel>();
        public ApplyRadioButtonViewModel ApplyRadioButtonViewModel => App.Current.Services.GetService<ApplyRadioButtonViewModel>();

        public IconSet IconSet => App.Current.Services.GetService<IconSet>();

    }
}
