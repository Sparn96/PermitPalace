﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.Data
{
    
    public class PERSONNEL_DATA : DatabaseTable
    {
        [Key]
        public Guid PERSONNEL_ID { get; set; }
        public string SERVICE { get; set; }
        public string DOD_NUMBER { get; set; }
        public string RANK { get; set; }
        public string LAST_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public string MOS { get; set; }
        public string EDIPI { get; set; }
        public string LAST_4 { get; set; }
        public string ORGANIZATION { get; set; }
        public string BILLET { get; set; }
        public string CURRENT_PLT { get; set; }
        public DateTime DOB { get; set; }
        public int AGE { get; set; }
        public string DOR { get; set; }
        public string TIG { get; set; }
        public string AFADBD { get; set; }
        public string TIS { get; set; }
        public string PEBD { get; set; }
        public string EAS { get; set; }
        public string DCTB { get; set; }
        public string HEIGHT { get; set; }
        public string HEIGHT_IN_FEET { get; set; }
        public string HEIGHT_IN_INCHES { get; set; }
        public string WEIGH_IN_DATE { get; set; }
        public string WEIGHT { get; set; }
        public string BODY_FAT_PERCENT { get; set; }
        public string HAIR_COLOR { get; set; }
        public bool WEARS_GLASSES { get; set; }
        public string EYE_COLOR { get; set; }
        public string SEX { get; set; }
        public string MED_CERT_REQ { get; set; }
        public string BLOOD_TYPE { get; set; }
        public string RELIGON { get; set; }
        public string BMOS { get; set; }
        public string AMOS_1 { get; set; }
        public string AMOS_2 { get; set; }
        public string AMOS_3 { get; set; }
        public string AMOS_4 { get; set; }
        public string EDUCATION { get; set; }
        public string CERTIFCATE { get; set; }
        public string STEEL_TOE_BOOTS { get; set; }
        public string GLOVES { get; set; }
        public string GORTEX_TOP { get; set; }
        public string GORTEX_BOTTOM { get; set; }
        public string HELMET_SIZE { get; set; }
        public string FLAK_SIZE { get; set; }
        public string PFT_SCORE { get; set; }
        public string PFT_CLASS { get; set; }
        public string PFT_DATE { get; set; }
        public string CFT_SCORE { get; set; }
        public string CFT_CLASS { get; set; }
        public string CFT_DATE { get; set; }
        public string RIFLE_RANGE_SCORE { get; set; }
        public string RIFLE_CLASS { get; set; }
        public string RIFLE_RANGE_DATE { get; set; }
        public string PISTOL_SCORE { get; set; }
        public string PISTOL_CLASS { get; set; }
        public string PISTOL_DATE { get; set; }
        public string SWIM_QUAL { get; set; }
        public string SWIM_QUAL_REQUAL { get; set; }
        public string MCMAP { get; set; }
        public string MCMAP_DATE { get; set; }
        public string PME_RESIDENT { get; set; }
        public string PME_NON_RESIDENT { get; set; }
        public string MOS_SCHOOL { get; set; }
        public string MARRIED_OR_SINGLE { get; set; }
        public string ANNIVESARY_DATE { get; set; }
        public string MARINES_ADDRESS { get; set; }
        public string WORK_NUMBER { get; set; }
        public string HOME_NUMBER { get; set; }
        public string CELL_NUMBER { get; set; }
        public string SPOUSE_NAME { get; set; }
        public string SPOUSE_ADDRESS { get; set; }
        public string SPOUSE_PHONE_NUMBER { get; set; }
        public DateTime SPOUSE_DOB { get; set; }
        public string _1ST_CHILDS_NAME { get; set; }
        public string _1ST_CHILDS_DOB { get; set; }
        public string _1ST_CHILDS_AGE { get; set; }
        public string _1ST_CHILD_RELATIONSHIP { get; set; }
        public string _2ND_CHILDS_NAME { get; set; }
        public string _2ND_CHILDS_DOB { get; set; }
        public string _2ND_CHILDS_AGE { get; set; }
        public string _2ND_CHILDS_RELATIONSHIP { get; set; }
        public string _3RD_CHILDS_NAME { get; set; }
        public string _3RD_CHILDS_DOB { get; set; }
        public string _3RD_CHILDS_AGE { get; set; }
        public string _3RD_CHILDS_RELATIONSHIP { get; set; }
        public string _4TH_CHILDS_NAME { get; set; }
        public string _4TH_CHILDS_DOB { get; set; }
        public string _4TH_CHILDS_AGE { get; set; }
        public string _4TH_CHILDS_RELATIONSHIP { get; set; }
        public string _5TH_CHILDS_NAME { get; set; }
        public string _5TH_CHILDS_DOB { get; set; }
        public string _5TH_CHILDS_AGE { get; set; }
        public string _5TH_CHILDS_RELATIONSHIP { get; set; }
        public string NOK_NAME { get; set; }
        public string NOK_RELATION { get; set; }
        public string NOK_ADDRESS { get; set; }
        public string NOK_PHONE_NUMBER { get; set; }
        public string NOK_1_NAME { get; set; }
        public string NOK_1_RELATION { get; set; }
        public string NOK_1_ADDRESS { get; set; }
        public string NOK_1_PHONE_NUMBER { get; set; }
        public string HOME_OF_RECORD { get; set; }
        public string PLACE_OF_BIRTH { get; set; }
        public string CIVILIAN_LIC_STATE { get; set; }
        public string CIVILIAN_LIC_NUMBER { get; set; }
        public string CIVILIAN_ISSUE_DATE { get; set; }
        public string CIVILIAN_EXP_DATE { get; set; }
        public string CLASS_OF_VEHICLE { get; set; }
        public string ENDORSEMENTS { get; set; }
        public string _1ST_POV_YEAR { get; set; }
        public string _1ST_POV_MAKE { get; set; }
        public string _1ST_POV_COLOR { get; set; }
        public string _1ST_POV_MODEL { get; set; }
        public string LICENSE_PLATE_NUMBER_1 { get; set; }
        public string _2ND_POV_YEAR { get; set; }
        public string _2ND_POV_MAKE { get; set; }
        public string _2ND_POV_MODEL { get; set; }
        public string _2ND_POV_COLOR { get; set; }
        public string LICENSE_PLATE_NUMBER_2 { get; set; }
        public string _1ST_MOTORCYLCE_MAKE { get; set; }
        public string _1ST_MOTORCYCLE_YEAR { get; set; }
        public string LICENSE_PLATE_NUMBER_3 { get; set; }
        public string CAR_INSURANCE_COMPANY { get; set; }
        public string CAR_INSURANCE_EXPIRES { get; set; }
        public string INSURANCE_POLICY_NUMBER { get; set; }
        public string MOTORCYCLE_INSURANCE_COMPANY { get; set; }
        public string MOTORCYCLE_INSURANCE_EXPIRES { get; set; }
        public string MOTORCYCLE_POLICY_NUMBER { get; set; }
        public string MOTORCYCLE_PLATE_NUMBER1 { get; set; }
        public string MOTORCYCLE_SAFE_FOUDATION_LEVEL { get; set; }
        public string OF_346_NUMBER { get; set; }
        public string OF_346_ISSUE { get; set; }
        public string OF_346_EXPIRES { get; set; }
        public string MEDICAL_CERT_EXPIRES { get; set; }
        public string HIGH_RISK_LETTER { get; set; }
        public string HIGH_RISK_LETTER_DATE { get; set; }
        public string DIC_CARD_NUMBER { get; set; }
        public bool IMVOV_HMMWV_3503AO { get; set; }
        public bool IMVOV_HMMWV_3504AO { get; set; }
        public bool IMVOV_HMMWV_3505AO { get; set; }
        public bool IMVOV_HMMWV_3506AO { get; set; }
        public bool IMVOV_HMMWV_3507AO { get; set; }
        public bool IMVOV_HMMWV_3508AO { get; set; }
        public bool IMVOV_HMMWV_3509AO { get; set; }
        public bool M1116_ITV { get; set; }
        public bool M998_1035_1038_1123_A2 { get; set; }
        public bool M1043_44_45_46_A1_A2 { get; set; }
        public bool M1114_51_52_65A1 { get; set; }
        public bool M996_997_A1_A2AMB { get; set; }
        public bool M1097_A2 { get; set; }
        public bool MRC145_148 { get; set; }
        public bool MAK { get; set; }
        public bool IMVOV_MK3510AO { get; set; }
        public bool IMVOV_MK3511AO { get; set; }
        public bool IMVOV_MK3512AO { get; set; }
        public bool IMVOV_MK3513AO { get; set; }
        public bool MK23_25_27_28 { get; set; }
        public bool MK29_30_DUMP { get; set; }
        public bool MK31 { get; set; }
        public bool MK970_REFUELER { get; set; }
        public bool MK36_WRECKER { get; set; }
        public bool MAS { get; set; }
        public bool M198 { get; set; }
        public bool M777 { get; set; }
        public bool MK48_LVS { get; set; }
        public bool MK14 { get; set; }
        public bool MK15_15A1_WRECKER { get; set; }
        public bool MK16 { get; set; }
        public bool MK17_17A1 { get; set; }
        public bool MK18_18A1 { get; set; }
        public bool TANDEMTOW { get; set; }
        public bool MKR18 { get; set; }
        public bool MKR16 { get; set; }
        public bool M870_870A1_870A2 { get; set; }
        public bool M870A2E1 { get; set; }
        public bool MRAP_CAT_I_II { get; set; }
        public bool MAXX_PRO { get; set; }
        public bool RG_31 { get; set; }
        public bool MRAP_CAT_III { get; set; }
        public bool HAZMAT { get; set; }
        public bool AMMO { get; set; }
        public bool BUS { get; set; }
        public bool _5_K_FORKLIFT { get; set; }
        public bool EBFL_MMV { get; set; }
        public bool OLD_TRAM { get; set; }
        public bool NEW_TRAM { get; set; }
        public bool EET { get; set; }
        public bool MEP831A_GEN { get; set; }
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
        public string REMARKS { get; set; }

    }
}
