using Microsoft.AspNetCore.Mvc.Rendering;
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
    public static class Rank
    {
        public static SelectList GetRanksAsSelectList()
        {
            var ranks = new List<SelectListItem> {
                    new SelectListItem { Value = null, Text="None" },
                    new SelectListItem { Value = "PVT", Text = "PVT" },
                    new SelectListItem { Value = "PFC", Text = "PFC" },
                    new SelectListItem { Value = "LCPL", Text = "LCPL" },
                    new SelectListItem { Value = "CPL", Text = "CPL" },
                    new SelectListItem { Value = "SGT", Text = "SGT" },
                    new SelectListItem { Value = "SSGT", Text = "SSGT" },
                    new SelectListItem { Value = "GYSGT", Text = "GYSGT" },
                    new SelectListItem { Value = "MSGT", Text = "MSGT" },
                    new SelectListItem { Value = "1STSGT", Text = "1STSGT" },
                    new SelectListItem { Value = "MGYSGT", Text = "MGYSGT" },
                    new SelectListItem { Value = "SGTMAJ", Text = "SGTMAJ" },
                    new SelectListItem { Value = "WO", Text = "WO" },
                    new SelectListItem { Value = "CWO2", Text = "CWO2" },
                    new SelectListItem { Value = "CWO3", Text = "CWO3" },
                    new SelectListItem { Value = "CWO4", Text = "CWO4" },
                    new SelectListItem { Value = "CWO5", Text = "CWO5" },
                    new SelectListItem { Value = "2NDLT", Text = "2NDLT" },
                    new SelectListItem { Value = "1STLT", Text = "1STLT" },
                    new SelectListItem { Value = "CAPT", Text = "CAPT" },
                    new SelectListItem { Value = "MAJ", Text = "MAJ" },
                    new SelectListItem { Value = "LTCOL", Text = "LTCOL" },
                    new SelectListItem { Value = "BGEN", Text = "BGEN" },
                    new SelectListItem { Value = "MGEN", Text = "MGEN" },
                    new SelectListItem { Value = "LGEN", Text = "LGEN" },
                    new SelectListItem { Value = "GEN", Text = "GEN" },
                    new SelectListItem { Value = "HN", Text = "HN" },
                    new SelectListItem { Value = "HM3", Text = "HM3" },
                    new SelectListItem { Value = "HM2", Text = "HM2" },
                    new SelectListItem { Value = "HM1", Text = "HM1" },
                    new SelectListItem { Value = "CHIEF", Text = "CHIEF" },
                    new SelectListItem { Value = "SENIOR CHIEF", Text = "SENIOR CHIEF" },
                    new SelectListItem { Value = "MASTER CHIEF", Text = "MASTER CHIEF" }
            };
           return new SelectList(ranks, "Value", "Text");
        }
        public static List<string> GetRanks()
        {
            return new List<string>()
        {
            "PVT"
            ,"PFC"
            ,"LCPL"
            ,"CPL"
            ,"SGT"
            ,"SSGT"
            ,"GYSGT"
            ,"MSGT"
            ,"1STSGT"
            ,"MGYSGT"
            ,"SGTMAJ"
            ,"WO"
            ,"CWO2"
            ,"CWO3"
            ,"CWO4"
            ,"CWO5"
            ,"2NDLT"
            ,"1STLT"
            ,"CAPT"
            ,"MAJ"
            ,"LTCOL"
            ,"COL"
            ,"BGEN"
            ,"MGEN"
            ,"LGEN"
            ,"GEN"
            ,"HN"
            ,"HM3"
            ,"HM2"
            ,"HM1"
            ,"CHIEF"
            ,"SENIOR CHIEF"
            ,"MASTER CHIEF"
        };
        }
        
    }
}
