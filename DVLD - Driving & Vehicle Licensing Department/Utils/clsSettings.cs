namespace DVLD_UI.Utils
{
    public static class clsSettings
    {
        public const int DefaultUserID = -1;
        public static int LoggedUserID { get; set; } = DefaultUserID;
        public const string AppName = "DVLD";
        public static string AppTitle => $"{AppName} - Driving & Vehicle Licensing Department";
        public static string AppVersion => "1.0.0";
        public static string AppDescription => "Driving & Vehicle Licensing Department Application";
        public static string AppAuthor => "Bechar Gherbi";
        public static string AppCopyRight => "DVLD 2025";
        public static string AppLicense => "DVLD License";
    }
}
