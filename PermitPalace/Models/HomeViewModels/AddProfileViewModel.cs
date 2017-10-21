using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.Models.HomeViewModels
{

    public class AddProfileViewModel
    {
        [Required]
        public string RANK { get; set; }
        [Required]
        public string LAST_NAME { get; set; }
        [Required]
        public string FIRST_NAME { get; set; }
        [Required]
        public string MIDDLE_NAME { get; set; }
        [Required]
        public string DOD_ID_NUMBER { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        public string SEX { get; set; }
        [Required]
        public int AGE { get; set; }
        [Required]
        public int HEIGHT_IN_INCHES { get; set; }
        [Required]
        public string WEIGHT { get; set; }
        [Required]
        public string HOME_OF_RECORD { get; set; }
        [Required]
        public string PLACE_OF_BIRTH { get; set; }
        [Required]
        public string CIVILIAN_LIC_STATE { get; set; }
        [Required]
        public string CIVILIAN_LIC_NUMBER { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime CIV_ISSUE_DATE { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime CIV_EXP_DATE { get; set; }
        [Required]
        public string CLASS_OF_VEHICLE { get; set; }
        [Required]
        public string HAIR_COLOR { get; set; }
        [Required]
        public string EYE_COLOR { get; set; }
        [Required]
        public string MED_CERT_REQUIRED { get; set; }
        public bool WEARS_GLASSES { get; set; }
        public bool POOR_VIS_IN_ONE_OR_BOTH { get; set; }
        public bool EYE_DISEASE { get; set; }
        public bool POOR_HEARING_IN_ONE_OR_BOTH { get; set; }
        public bool DIABETES { get; set; }
        public bool PALPITATION_CHEST_PAIN_SHORT_BREATH { get; set; }
        public bool DIZZINESS_OR_FAINT_SPELLS { get; set; }
        public bool FREQUENT_OR_SEVERE_HEADACHES { get; set; }
        public bool HIGH_OR_LOW_BLOOD_PRESSURE { get; set; }
        public bool DRUG_OR_NARCODIC_HABIT { get; set; }
        public bool ARTHRITIS_RHEUMATISM_SWOLLEN_OR_PAINFUL_JOINTS { get; set; }
        public bool LOSS_OF_HAND_ARM_FOOT_OR_LEG { get; set; }
        public bool DEFOMITY_OF_HAND_ARM_FOOT_OR_LEG { get; set; }
        public bool NERVOUS_OR_MENTAL_TROUBLE { get; set; }
        public bool BLACKOUTS_EPILIEPSY { get; set; }
        public bool SUGAR_OR_ALBUMIN_IN_URINE { get; set; }
        public bool EXCESSIVE_DRINKING_HABIT { get; set; }
        public bool OTHER_SERIOUS_DEFECTS_OR_DISEASE { get; set; }
        public bool DOES_WEAR_HEARING_AID { get; set; }
        public bool DOES_WEAR_GLASSES_OR_CONTACTS_WHILE_DRIVING { get; set; }
        public string _3270 { get; set; }
    }
}
