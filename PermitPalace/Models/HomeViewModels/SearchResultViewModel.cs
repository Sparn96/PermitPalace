using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.Models.HomeViewModels
{
    public class SearchResultViewModel
    {
        public Guid filed_document_guid { get; set; }
        public string document_name { get; set; }
        public string document_owner_name { get; set; }
        public bool Is_Signed { get; set; }
        public Guid LinkedPermit { get; set; }
    }
}
