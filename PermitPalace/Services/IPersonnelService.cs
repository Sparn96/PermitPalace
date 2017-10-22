using PermitPalace.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.Services
{
    public interface IPersonnelService
    {
        //PERSONNEL_DATA Add(BasicPersonnelData basic_data);
        PERSONNEL_DATA Add(PERSONNEL_DATA data, string user);
        PERSONNEL_DATA Update(PERSONNEL_DATA update, string user);
        PERSONNEL_DATA Remove(PERSONNEL_DATA remove, string user);
        PERSONNEL_DATA Get(string DOD_NUMBER);
        PERSONNEL_DATA Get(Guid personnel_guid);
        BasicPersonnelInfo GetBasicInformation(string DOD_NUMBER);
        IEnumerable<PERSONNEL_DATA> FindByName(string full_name);
        IEnumerable<PERSONNEL_DATA> FindByDOB(DateTime dob);
        IEnumerable<PERSONNEL_DATA> FindByPlaceOfBirth(string place);
       // PERSONNEL_DATA FindByPermitNumber(string number); // assuming the permit number is a one to one
        IEnumerable<PERSONNEL_DATA> FindByRank(string rank);
    }
    public class PersonnelService : IPersonnelService
    {
        ApplicationDbContext _context;
        public PersonnelService(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        //public PERSONNEL_DATA Add(BasicPersonnelData basic_data)  //use basic data as referecne when building templtwe
        //{
        //    PERSONNEL_DATA data = new PERSONNEL_DATA();
        //    data.FIRST_NAME = basic_data.FIRST_NAME;
        //    data.LAST_FIRST_MI = basic_data.LAST_FIRST + " " + basic_data.MIDDLE_INITIAL;
        //    data.HEIGHT_IN_INCHES =  basic_data.HEIGHT_IN_INCHES;
        //    data.HOME_OF_RECORD =  basic_data.HOME_OF_RECORD;
        //}

        public PERSONNEL_DATA Add(PERSONNEL_DATA data, string user)
        {
            data.last_modified_by = user;
            data.date_last_modified = DateTime.Now;
            data.date_created = DateTime.Now;
            data.created_by = user;

            var da = _context.PERSONNEL_DATA.Add(data);
            _context.SaveChanges();
            return da.Entity;
        }

        public IEnumerable<PERSONNEL_DATA> FindByDOB(DateTime dob)
        {
            return _context.PERSONNEL_DATA.Where(f => f.DOB.Year == dob.Year && f.DOB.DayOfYear == dob.DayOfYear);
        }

        public IEnumerable<PERSONNEL_DATA> FindByName(string full_name)
        {
            throw new NotImplementedException();
            //need to build a union list of all the possible names?
        }

        //public PERSONNEL_DATA FindByPermitNumber(string number)
        //{
        //    return _context.PERSONNEL_DATA.FirstOrDefault(f => f.number)
        //}

        public IEnumerable<PERSONNEL_DATA> FindByPlaceOfBirth(string place)
        {
            return _context.PERSONNEL_DATA.Where(f => f.PLACE_OF_BIRTH == place);
        }

        public IEnumerable<PERSONNEL_DATA> FindByRank(string rank)
        {
            return _context.PERSONNEL_DATA.Where(f => f.RANK == rank);
        }

        public PERSONNEL_DATA Get(string DOD_NUMBER)
        {
            return _context.PERSONNEL_DATA.FirstOrDefault(f => f.DOD_NUMBER == DOD_NUMBER);
        }

        public PERSONNEL_DATA Get(Guid personnel_guid)
        {
            return _context.PERSONNEL_DATA.FirstOrDefault(f => f.PERSONNEL_ID == personnel_guid);
        }

        public BasicPersonnelInfo GetBasicInformation(string DOD_NUMBER)
        {
            BasicPersonnelInfo marine = new BasicPersonnelInfo();
            PERSONNEL_DATA model = Get(DOD_NUMBER);
            marine.DOD_NUMBER = model.DOD_NUMBER;
            marine.RANK = model.RANK;
            marine.FIRST_NAME = model.FIRST_NAME;
            marine.LAST_NAME = model.LAST_NAME;
            marine.MIDDLE_NAME = model.MIDDLE_NAME;
            marine.HEIGHT_IN_INCHES = model.HEIGHT_IN_INCHES;
            marine.DOB = model.DOB;
            marine.SEX = model.SEX;
            marine.AGE = model.AGE;
            marine.WEIGHT = model.WEIGHT;
            marine.HOME_OF_RECORD = model.HOME_OF_RECORD;
            marine.PLACE_OF_BIRTH = model.PLACE_OF_BIRTH;
            marine.CIVILIAN_LIC_STATE = model.CIVILIAN_LIC_STATE;
            marine.CIVILIAN_LIC_NUMBER = model.CIVILIAN_LIC_NUMBER;
            marine.CIVILIAN_ISSUE_DATE = model.CIVILIAN_ISSUE_DATE;
            marine.CIVILIAN_EXP_DATE = model.CIVILIAN_EXP_DATE;
            marine.CLASS_OF_VEHICLE = model.CLASS_OF_VEHICLE;
            marine.HAIR_COLOR = model.HAIR_COLOR;
            marine.EYE_COLOR = model.EYE_COLOR;
            marine.MED_CERT_REQ = model.MED_CERT_REQ;
            marine.WEARS_GLASSES = model.WEARS_GLASSES;
            //HEALTH EVAL.
            marine.POOR_HEARING_IN_ONE_OR_BOTH = model.POOR_HEARING_IN_ONE_OR_BOTH;
            marine.EYE_DISEASE = model.EYE_DISEASE;
            marine.POOR_VIS_IN_ONE_OR_BOTH = model.POOR_VIS_IN_ONE_OR_BOTH;
            marine.DIABETES = model.DIABETES;
            marine.PALPITATION_CHEST_PAIN_SHORT_BREATH = model.PALPITATION_CHEST_PAIN_SHORT_BREATH;
            marine.DIZZINESS_OR_FAINT_SPELLS = model.DIZZINESS_OR_FAINT_SPELLS;
            marine.FREQUENT_OR_SEVERE_HEADACHES = model.FREQUENT_OR_SEVERE_HEADACHES;
            marine.HIGH_OR_LOW_BLOOD_PRESSURE = model.HIGH_OR_LOW_BLOOD_PRESSURE;
            marine.DRUG_OR_NARCODIC_HABIT = model.DRUG_OR_NARCODIC_HABIT;
            marine.ARTHRITIS_RHEUMATISM_SWOLLEN_OR_PAINFUL_JOINTS = model.ARTHRITIS_RHEUMATISM_SWOLLEN_OR_PAINFUL_JOINTS;
            marine.LOSS_OF_HAND_ARM_FOOT_OR_LEG = model.LOSS_OF_HAND_ARM_FOOT_OR_LEG;
            marine.DEFOMITY_OF_HAND_ARM_FOOT_OR_LEG = model.DEFOMITY_OF_HAND_ARM_FOOT_OR_LEG;
            marine.NERVOUS_OR_MENTAL_TROUBLE = model.NERVOUS_OR_MENTAL_TROUBLE;
            marine.BLACKOUTS_EPILIEPSY = model.BLACKOUTS_EPILIEPSY;
            marine.SUGAR_OR_ALBUMIN_IN_URINE = model.SUGAR_OR_ALBUMIN_IN_URINE;
            marine.EXCESSIVE_DRINKING_HABIT = model.EXCESSIVE_DRINKING_HABIT;
            marine.OTHER_SERIOUS_DEFECTS_OR_DISEASE = model.OTHER_SERIOUS_DEFECTS_OR_DISEASE;
            marine.DOES_WEAR_HEARING_AID = model.DOES_WEAR_HEARING_AID;
            marine.DOES_WEAR_GLASSES_OR_CONTACTS_WHILE_DRIVING = model.DOES_WEAR_GLASSES_OR_CONTACTS_WHILE_DRIVING;
            marine._3270 = model._3270;
            return marine;
        }

        public PERSONNEL_DATA Remove(PERSONNEL_DATA remove, string user)
        {
            remove.last_modified_by = user;
            remove.date_last_modified = DateTime.Now;
            var da = _context.PERSONNEL_DATA.Remove(remove);
            _context.SaveChanges();
            return da.Entity;
        }

        public PERSONNEL_DATA Update(PERSONNEL_DATA update, string user)
        {
            update.last_modified_by = user;
            update.date_last_modified = DateTime.Now;
            var da = _context.PERSONNEL_DATA.Update(update);
            _context.SaveChanges();
            return da.Entity;
        }
    }
}
