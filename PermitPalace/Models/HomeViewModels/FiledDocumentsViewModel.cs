using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.Models.HomeViewModels
{
    public class FiledDocumentsViewModel
    {
        public string Personnel_DOD_ID { get; set; }
        public string Rank { get; set; }
        public string Approved_By_Supervisor_DOD_ID { get; set; }
        public string Document_Type { get; set; }
    }

}
