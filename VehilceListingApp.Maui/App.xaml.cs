namespace CarListingApp.Maui
{
    public partial class App
    {
        public App()
        {
            // Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(
            //     "Ngo9BigBOggjHTQxAR8/V1NMaF5cXmtCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWX5eeXVWR2NYWUZ/XEA=");
            if (File.Exists(Directory.GetCurrentDirectory() + "/SyncfusionLicense.txt"))
            {
                string licenseKey =
                    File.ReadAllText(Directory.GetCurrentDirectory() + "/SyncfusionLicense.txt");
                Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licenseKey);
            }
            
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}