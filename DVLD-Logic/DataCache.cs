using DVLD_Logic;
using System.Data;
namespace DVLD_Data
{
    public class DataCache
    {
        private static DataCache _instance;
        private DataTable _usersTable;
        private DataTable _personsTable;
        private DataTable _applicationTypesTable;
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
        private DataTable LoadApplicationTypes()
        {
            return ApplicationTypes.GetAllApplicationTypes();
        }
        private DataTable LoadPersons()
        {
            return clsPeopleDAL.GetAllPeople();
        }
        private DataTable LoadUsers()
        {
            return clsUserDAL.GetAllUsers();
        }
    }
}
