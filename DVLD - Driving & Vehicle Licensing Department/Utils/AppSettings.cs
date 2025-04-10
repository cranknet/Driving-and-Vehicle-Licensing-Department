﻿namespace DVLD_UI.Utils
{
    public static class AppSettings
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
        public const string DeletePersonDialogTitle = "Confirm Person Deletion";
        public const string PersonDeleteSuccess = "Person with ID: {0} deleted successfully";
        public const string PersonDeleteFailed = "Couldn't delete Person with ID: {0}!";
        // Delete Confirmation and Result Messages
        public const string ConfirmDeleteUser = "Are you sure you want to delete!\nUser with ID {0}?";
        public const string DeleteUserDialogTitle = "Confirm User Deletion";
        public const string UserDeleteSuccess = "User with ID: {0} deleted successfully";
        public const string UserDeleteFailed = "Couldn't delete User with ID: {0}!";
        // Menu Options (as text for buttons and selections)
        public const string MenuApplications = "APPLICATIONS";
        public const string MenuDrivers = "DRIVERS";
        public const string MenuPeoples = "PEOPLES";
        public const string MenuUsers = "USERS";
        public const string MenuUserSettings = "USER SETTINGS";
        // Other common notifications and messages
        public const string ProfileSavedSuccess = "Person saved successfully";
        public const string ProfileSaveFailed = "Can't save Person";
        // Grid View Column ID Names
        public const string UserIDColumnName = "UserID";
        public const string PersonIDColumnName = "PersonID";
        public const string ApplicationTypeIDColumnName = "ApplicationTypeID";
        public const string TestITypeDColumnName = "TestTypeID";
        public const string TestAppointmentIDColumnName = "TestAppointmentID";
        public const string LDLApplicationIDColumnName = "LDLApplicationID";
        //Login Data Path & Record
        public const string LoginRecord = "{0}@-@{1}";
        public const string LoginSavePath = "LoginData.txt";
        public const string DefaultFilterOptionValue = "None";
        //Add Local Driving License Application 
        public const string AddLocalDLApplication = "Add Local Driving License Application";
        public const string LocalDLDAddedSuccess = "Application Added Successfully!";
        public const string LocalDLDAddedFailed = "Failed to add the application. Please try again.";
        public const string ApplicationAlreadyExists = "Application already exists with ID:{0}";
        public const string SelectPersonFirst = "Please select a person first";
        public const string SelectLicenseClass = "Please select a license class";
        // Test Appointments
        public const string TestAppointmentTypeTitle = "{0} Appointments";
        public const string ScheduleTestTitle = "Schedule {0}";
        public const string TestAppointmentLoadFailedFromCell = "Couldn't load the Test Appointment from the selected cell, invalid ID received!";
        public const string TestAppointmentScheduledSuccessfully = "Test Appointment has been scheduled successfully!";
        // Take Test
        public const string TakeTestTitle = "Take {0} Test";
        public const string TakeTestSuccessUpdate = "Test updated successfully!";
        public const string TakeTestSuccessAdded = "Test added successfully!";
        public const string TakeTestFailAdd = "Couldn't add test!";


        public enum MenuItem
        {
            // Main menu items
            Peoples,
            Users,
            Applications,
            Drivers,
            UserSettings,
            // Application sub-menu
            ApplicationType,
            TestType,
            LocalDLApplication,
            AddLDLApplication,
            AddInternationalDLApplication,
            // Test Type sub-menu
            EditTestType,
            // Application Type sub-menu
            EditApplicationType,
            // LDL Application sub-menu
            //Schudule Test sub-menu
            ScheduleVisionTest,
            ScheduleWritingTest,
            ScheduleDrivingTest

        }
        public enum EnMode
        {
            Read = 0,
            Add = 1,
            Update = 2,
        }
        public enum TestType
        {
            Vision = 1,
            Writing = 2,
            Driving = 3
        }
    }
}