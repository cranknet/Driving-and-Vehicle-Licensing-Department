namespace DVLD_UI.Utils
{
    public static class Settings
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
        // Application Titles and Common Labels
        public const string PersonIdLabelPrefix = "PERSON ID: "; // Used to display the person ID label
        // Login Messages
        public const string LoginSuccessful = "Login Successful";
        public const string InvalidCredentials = "Invalid username or password.";
        public const string UsernamePasswordRequired = "Username and password are required.";
        // Person Profile Messages (for PersonProfileCard)
        public const string SaveButtonText = "SAVE";
        public const string AddButtonText = "ADD";
        // Validation Messages
        public const string NationalNumberExists = "National number already exists!";
        // Delete Confirmation and Result Messages
        public const string ConfirmDeletePerson = "Are you sure you want to delete!\nPerson with ID {0}?";
        public const string PersonDeleteSuccess = "Person with ID: {0} deleted successfully";
        public const string PersonDeleteFailed = "Couldn't delete Person with ID: {0}!";
        // Menu Options (as text for buttons and selections)
        public const string MenuApplications = "APPLICATIONS";
        public const string MenuDrivers = "DRIVERS";
        public const string MenuPeoples = "PEOPLES";
        public const string MenuUsers = "USERS";
        public const string MenuUserSettings = "USER SETTINGS";
        // Other common notifications and messages
        public const string ProfileSavedSuccess = "Person saved successfully";
        public const string ProfileSaveFailed = "Can't save Person";
        public const string UserIDCellName = "UserID";
        public const string PersonIDCellName = "PersonID";
        public const string ApplicationTypeIDCellName = "ApplicationTypeID";
        //Login Data Path & Record
        public const string LoginRecord = "{0}@-@{1}";
        public const string LoginSavePath = "LoginData.txt";
        public const string DefaultFilterOptionValue = "None";
    }
}
