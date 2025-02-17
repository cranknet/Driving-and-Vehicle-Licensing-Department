using DVLD_Data;
using System.Data;

namespace DVLD_Logic
{
    public class clsCountry
    {
        public static DataTable GetListCountries()
        {
            return clsCountryDAL.GetCountries();
        }
    }
}
