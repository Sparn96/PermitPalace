using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.Data
{
    public class PERMIT_DATA : DatabaseTable
    {
        [Key]
        public Guid PERMIT_GUID { get; set; }
        public DateTime DATE_ISSUED { get; set; }
        public DateTime DATE_EXP { get; set; }
        public string PERMIT_NUMBER { get; set; }
        public string APPROVED_BY { get; set; }
        public Guid PERSONNEL_ID { get; set; }
    }
}
