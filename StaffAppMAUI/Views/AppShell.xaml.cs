using StaffApp.ViewModels;

namespace StaffApp.Views
{
    public partial class AppShell
    {
        public AppShell()
        {
            InitializeComponent();

        }

        bool isFullAuthenticated = false;
        public bool IsFullAuthenticated
        {
            get => isFullAuthenticated;
            set
            {
                isFullAuthenticated = value;
                OnPropertyChanged("IsFullAuthenticated");
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

    }
}