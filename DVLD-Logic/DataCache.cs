using DVLD_Logic;
using System.Data;
namespace DVLD_Data
{
    public class DataCache
    {
        private static DataCache _instance;
        private DataTable _usersTable;
        private DataTable _personsTable;
        private DataTable _nonUserPersonsTable;
        private DataTable _applicationTypesTable;
        private DataTable _testTypesTable;
        private DataTable _driversTable;
        private DataTable _licenseClassesTable;
        private DataTable _lDLApplications;
        private DataCache() { }
        public static DataCache Instance
        {
            get
            {
                if (_instance == null) _instance = new DataCache();
                return _instance;
            }
        }
        public DataTable GetUsers()
        {
            if (_usersTable == null)
            {
                _usersTable = LoadUsers();
            }
            return _usersTable;
        }
        public DataTable GetPersons()
        {
            if (_personsTable == null)
            {
                _personsTable = LoadPersons();
            }
            return _personsTable;
        }
        public DataTable GetApplicationTypes()
        {
            if ((_applicationTypesTable == null))
            {
                _applicationTypesTable = LoadApplicationTypes();
            }
            return _applicationTypesTable;
        }
        public DataTable GetNonUserPersons()
        {
            if (_nonUserPersonsTable == null)
            {
                _nonUserPersonsTable = LoadNonUserPersons();
            }
            return _nonUserPersonsTable;
        }
        public DataTable GetTestTypes()
        {
            if (_testTypesTable == null)
            {
                _testTypesTable = LoadTestTypes();
            }
            return _testTypesTable;
        }
        public DataTable GetDrivers()
        {
            if (_driversTable == null)
            {
                _driversTable = LoadDrivers();
            }
            return _driversTable;
        }
        public DataTable GetLicenseClasses()
        {
            if (_licenseClassesTable == null)
            {
                _licenseClassesTable = LoadLicenseClasses();
            }
            return _licenseClassesTable;
        }
        public DataTable GetLDLApplications()
        {
            if (_lDLApplications == null)
            {
                _lDLApplications = LoadLDLApplications();
            }
            return _lDLApplications;
        }
        public void RefreshUsers()
        {
            _usersTable = LoadUsers();
        }
        public void RefreshPersons()
        {
            _personsTable = LoadPersons();
        }
        public void RefreshApplicationTypes()
        {
            _applicationTypesTable = LoadApplicationTypes();
        }
        public void RefreshNonUserPersons()
        {
            _personsTable = LoadNonUserPersons();
        }
        public void RefreshTestTypes()
        {
            _testTypesTable = LoadTestTypes();
        }
        public void RefreshDrivers()
        {
            _driversTable = LoadDrivers();
        }
        public void RefreshLicenseClasses()
        {
            _licenseClassesTable = LoadLicenseClasses();
        }
        public void RefreshLDLApplications()
        {
            _lDLApplications = LoadLDLApplications();
        }
        private DataTable LoadApplicationTypes()
        {
            return ApplicationType.GetAllApplicationTypes();
        }
        private DataTable LoadPersons()
        {
            return People.GetAllPeople();
        }
        private DataTable LoadUsers()
        {
            return User.GetAllUsers();
        }
        private DataTable LoadNonUserPersons()
        {
            return People.GetAllNonUserPeople();
        }
        private DataTable LoadTestTypes()
        {
            return TestType.GetAllTestTypes();
        }
        private DataTable LoadDrivers()
        {
            return Driver.GetAllDrivers();
        }
        private DataTable LoadLicenseClasses()
        {
            return LicenseClass.GetAllLicenseClasses();
        }
        private DataTable LoadLDLApplications()
        {
            return clsApplication.GetAllLDLApplications();
        }
    }
}
