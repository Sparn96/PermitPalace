using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.GlobalUtilities
{
    public static class ApplicationRoles
    {
        public const string ADMIN = "Administrator";
        public const string SUPERVISOR = "Supervisor";
        public const string APPLICANT = "Applicant";
        public static string[] GetAllRoles()
        {
            return new string[] { ADMIN, SUPERVISOR, APPLICANT };
        }
    }
}
