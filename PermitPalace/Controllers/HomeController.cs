using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PermitPalace.Models;
using Microsoft.AspNetCore.Authorization;
using PermitPalace.GlobalUtilities;
using PermitPalace.Models.HomeViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using PermitPalace.Data;
using PermitPalace.Services;

namespace PermitPalace.Controllers
{
    public class HomeController : Controller
    {
        IPersonnelService _PersonnelService;
        public HomeController(IPersonnelService ips)
        {
            _PersonnelService = ips;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddProfile()
        {
            var states = new List<SelectListItem> {
                    new SelectListItem { Value = "AL", Text = "Alabama" },
                    new SelectListItem { Value = "AK", Text = "Alaska" },
                    new SelectListItem { Value = "AZ", Text = "Arizona" },
                    new SelectListItem { Value = "AR", Text = "Arkansas" },
                    new SelectListItem { Value = "CA", Text = "California" },
                    new SelectListItem { Value = "CO", Text = "Colorado" },
                    new SelectListItem { Value = "CT", Text = "Connecticut" },
                    new SelectListItem { Value = "DE", Text = "Delaware" },
                    new SelectListItem { Value = "FL", Text = "Florida" },
                    new SelectListItem { Value = "GA", Text = "Georgia" },
                    new SelectListItem { Value = "HI", Text = "Hawaii" },
                    new SelectListItem { Value = "ID", Text = "Idaho" },
                    new SelectListItem { Value = "IL", Text = "Illinois" },
                    new SelectListItem { Value = "IN", Text = "Indiana" },
                    new SelectListItem { Value = "IA", Text = "Iowa" },
                    new SelectListItem { Value = "KS", Text = "Kansas" },
                    new SelectListItem { Value = "KY", Text = "Kentucky" },
                    new SelectListItem { Value = "LA", Text = "Louisiana" },
                    new SelectListItem { Value = "ME", Text = "Maine" },
                    new SelectListItem { Value = "MD", Text = "Maryland" },
                    new SelectListItem { Value = "MA", Text = "Massachusetts" },
                    new SelectListItem { Value = "MI", Text = "Michigan" },
                    new SelectListItem { Value = "MN", Text = "Minnesota" },
                    new SelectListItem { Value = "MS", Text = "Mississippi" },
                    new SelectListItem { Value = "MO", Text = "Missouri" },
                    new SelectListItem { Value = "MT", Text = "Montana" },
                    new SelectListItem { Value = "NC", Text = "North Carolina" },
                    new SelectListItem { Value = "ND", Text = "North Dakota" },
                    new SelectListItem { Value = "NE", Text = "Nebraska" },
                    new SelectListItem { Value = "NV", Text = "Nevada" },
                    new SelectListItem { Value = "NH", Text = "New Hampshire" },
                    new SelectListItem { Value = "NJ", Text = "New Jersey" },
                    new SelectListItem { Value = "NM", Text = "New Mexico" },
                    new SelectListItem { Value = "NY", Text = "New York" },
                    new SelectListItem { Value = "OH", Text = "Ohio" },
                    new SelectListItem { Value = "OK", Text = "Oklahoma" },
                    new SelectListItem { Value = "OR", Text = "Oregon" },
                    new SelectListItem { Value = "PA", Text = "Pennsylvania" },
                    new SelectListItem { Value = "RI", Text = "Rhode Island" },
                    new SelectListItem { Value = "SC", Text = "South Carolina" },
                    new SelectListItem { Value = "SD", Text = "South Dakota" },
                    new SelectListItem { Value = "TN", Text = "Tennessee" },
                    new SelectListItem { Value = "TX", Text = "Texas" },
                    new SelectListItem { Value = "UT", Text = "Utah" },
                    new SelectListItem { Value = "VT", Text = "Vermont" },
                    new SelectListItem { Value = "VA", Text = "Virginia" },
                    new SelectListItem { Value = "WA", Text = "Washington" },
                    new SelectListItem { Value = "WV", Text = "West Virginia" },
                    new SelectListItem { Value = "WI", Text = "Wisconsin" },
                    new SelectListItem { Value = "WY", Text = "Wyoming" }
};
            var list = new SelectList(states, "Value", "Text");
            ViewBag.STATES = list;
            return View();
        }
        [HttpPost]
        public IActionResult AddProfile(AddProfileViewModel model)
        {
            if(ModelState.IsValid)
            {
                PERSONNEL_DATA marine = new PERSONNEL_DATA();
                if (_PersonnelService.Get(model.DOD_ID_NUMBER) == null)
                {
                    marine.DOD_NUMBER = model.DOD_ID_NUMBER;
                    marine.RANK = model.RANK;
                    marine.FIRST_NAME = model.FIRST_NAME;
                    marine.LAST_NAME = model.LAST_NAME;
                    marine.MIDDLE_NAME = model.MIDDLE_NAME;
                    marine.HEIGHT_IN_INCHES = model.HEIGHT_IN_INCHES.ToString();
                    marine.DOB = model.DOB;
                    marine.SEX = model.SEX;
                    marine.AGE = model.AGE;
                    marine.WEIGHT = model.WEIGHT;
                    marine.HOME_OF_RECORD = model.HOME_OF_RECORD;
                    marine.PLACE_OF_BIRTH = model.PLACE_OF_BIRTH;
                    marine.CIVILIAN_LIC_STATE = model.CIVILIAN_LIC_STATE;
                    marine.CIVILIAN_LIC_NUMBER = model.CIVILIAN_LIC_NUMBER;
                    marine.CIVILIAN_ISSUE_DATE = model.CIV_ISSUE_DATE;
                    marine.CIVILIAN_EXP_DATE = model.CIV_EXP_DATE;
                    marine.CLASS_OF_VEHICLE = model.CLASS_OF_VEHICLE;
                    marine.HAIR_COLOR = model.HAIR_COLOR;
                    marine.EYE_COLOR = model.EYE_COLOR;
                    marine.MED_CERT_REQ = model.MED_CERT_REQUIRED;
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

                    _PersonnelService.Add(marine);
                    return RedirectToAction("Index");
                }
                else
                {

                   
                }
            }
            else
            {
                
            }
            var states = new List<SelectListItem> {
                    new SelectListItem { Value = "AL", Text = "Alabama" },
                    new SelectListItem { Value = "AK", Text = "Alaska" },
                    new SelectListItem { Value = "AZ", Text = "Arizona" },
                    new SelectListItem { Value = "AR", Text = "Arkansas" },
                    new SelectListItem { Value = "CA", Text = "California" },
                    new SelectListItem { Value = "CO", Text = "Colorado" },
                    new SelectListItem { Value = "CT", Text = "Connecticut" },
                    new SelectListItem { Value = "DE", Text = "Delaware" },
                    new SelectListItem { Value = "FL", Text = "Florida" },
                    new SelectListItem { Value = "GA", Text = "Georgia" },
                    new SelectListItem { Value = "HI", Text = "Hawaii" },
                    new SelectListItem { Value = "ID", Text = "Idaho" },
                    new SelectListItem { Value = "IL", Text = "Illinois" },
                    new SelectListItem { Value = "IN", Text = "Indiana" },
                    new SelectListItem { Value = "IA", Text = "Iowa" },
                    new SelectListItem { Value = "KS", Text = "Kansas" },
                    new SelectListItem { Value = "KY", Text = "Kentucky" },
                    new SelectListItem { Value = "LA", Text = "Louisiana" },
                    new SelectListItem { Value = "ME", Text = "Maine" },
                    new SelectListItem { Value = "MD", Text = "Maryland" },
                    new SelectListItem { Value = "MA", Text = "Massachusetts" },
                    new SelectListItem { Value = "MI", Text = "Michigan" },
                    new SelectListItem { Value = "MN", Text = "Minnesota" },
                    new SelectListItem { Value = "MS", Text = "Mississippi" },
                    new SelectListItem { Value = "MO", Text = "Missouri" },
                    new SelectListItem { Value = "MT", Text = "Montana" },
                    new SelectListItem { Value = "NC", Text = "North Carolina" },
                    new SelectListItem { Value = "ND", Text = "North Dakota" },
                    new SelectListItem { Value = "NE", Text = "Nebraska" },
                    new SelectListItem { Value = "NV", Text = "Nevada" },
                    new SelectListItem { Value = "NH", Text = "New Hampshire" },
                    new SelectListItem { Value = "NJ", Text = "New Jersey" },
                    new SelectListItem { Value = "NM", Text = "New Mexico" },
                    new SelectListItem { Value = "NY", Text = "New York" },
                    new SelectListItem { Value = "OH", Text = "Ohio" },
                    new SelectListItem { Value = "OK", Text = "Oklahoma" },
                    new SelectListItem { Value = "OR", Text = "Oregon" },
                    new SelectListItem { Value = "PA", Text = "Pennsylvania" },
                    new SelectListItem { Value = "RI", Text = "Rhode Island" },
                    new SelectListItem { Value = "SC", Text = "South Carolina" },
                    new SelectListItem { Value = "SD", Text = "South Dakota" },
                    new SelectListItem { Value = "TN", Text = "Tennessee" },
                    new SelectListItem { Value = "TX", Text = "Texas" },
                    new SelectListItem { Value = "UT", Text = "Utah" },
                    new SelectListItem { Value = "VT", Text = "Vermont" },
                    new SelectListItem { Value = "VA", Text = "Virginia" },
                    new SelectListItem { Value = "WA", Text = "Washington" },
                    new SelectListItem { Value = "WV", Text = "West Virginia" },
                    new SelectListItem { Value = "WI", Text = "Wisconsin" },
                    new SelectListItem { Value = "WY", Text = "Wyoming" }
};
            var list = new SelectList(states, "Value", "Text");
            ViewBag.STATES = list;
            return View();

        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
