using DVLD_Data;
using System.Data;

namespace DVLD_Logic
{
    public class Country
    {
        public static DataTable GetListCountries()
        {
            return CountryDAL.GetCountries();
        }
    }
}
