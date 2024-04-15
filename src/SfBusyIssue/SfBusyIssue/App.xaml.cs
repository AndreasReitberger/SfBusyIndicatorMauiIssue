namespace SfBusyIssue
{
    public partial class App : Application
    {
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");

            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
