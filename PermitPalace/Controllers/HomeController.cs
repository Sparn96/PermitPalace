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
using Microsoft.AspNetCore.Hosting;
using System.IO;
using iTextSharp;

using iTextSharp.text;
using DocuSign.eSign.Api;

using iTextSharp.text.pdf;

using iTextSharp.text.xml;
using System.Collections;
using System.Text;
using Microsoft.Extensions.Primitives;
using DocuSign.eSign.Model;
using Newtonsoft.Json;
using DocuSign.eSign.Client;

namespace PermitPalace.Controllers
{
    public class HomeController : Controller
    {
        IPersonnelService _PersonnelService;
        IHostingEnvironment _HostingEnvironment;
        IDocumentService _DocumentService;
        IFileDocumentService _FileDocumentService;


        public HomeController(IPersonnelService ips, IHostingEnvironment env, IDocumentService idoc, IFileDocumentService ifds)
        {
            _PersonnelService = ips;
            _HostingEnvironment = env;
            _DocumentService = idoc;
            _FileDocumentService = ifds;
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
            if (ModelState.IsValid)
            {
                PERSONNEL_DATA marine = new PERSONNEL_DATA();
                if (_PersonnelService.Get(model.DOD_ID_NUMBER) == null)
                {
                    marine.DOD_NUMBER = model.DOD_ID_NUMBER;
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
                    marine.PERSONNEL_ID = new Guid();

                    _PersonnelService.Add(marine, HttpContext.User.Identity.Name);

                    var newMarine = _DocumentService.GetByName("NAVMC_10694.pdf");

                    FILLED_DOCUMENT newDoc = new FILLED_DOCUMENT();
                    newDoc.created_by = HttpContext.User.Identity.Name;
                    newDoc.date_created = DateTime.Now;
                    newDoc.date_last_modified = DateTime.Now;
                    //newDoc.DATE_SIGNED = null;
                    newDoc.DOCUMENT_GUID = newMarine.DOCUEMNT_GUID;
                    newDoc.DOCUMENT_NAME = marine.DOD_NUMBER + newMarine.DOCUMENT_NAME;
                    newDoc.DOD_ID_OF_APPROVING_SUPERVISOR = null;
                    newDoc.FILLED_DOCUMENT_GUID = new Guid();
                    newDoc.PDF_FILENAME = newMarine.DOCUMENT_NAME;
                    newDoc.IS_SIGNED = false;
                    newDoc.last_modified_by = HttpContext.User.Identity.Name;
                    //newDoc.PERMIT_GUID = null;
                    newDoc.PERSONNEL_OWNER = marine.PERSONNEL_ID;
                    _FileDocumentService.File(newDoc,HttpContext.User.Identity.Name);

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
        [HttpGet]
        public IActionResult FiledDocuments()
        {
            FiledDocumentsViewModel model = new FiledDocumentsViewModel();
            var docList = _DocumentService.GetAll();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var doc in docList)
            {
                items.Add(new SelectListItem() { Text = doc.DOCUMENT_NAME, Value = doc.DOCUMENT_NAME });
            }
            ViewBag.docs = new SelectList(items, "Text", "Value");
            return View();
        }
        [HttpPost]
        public IActionResult FiledDocuments(FiledDocumentsViewModel model)
        {
            //filter the search results from the query
            //redirect to results using another view model
            var allFiledDocs = _FileDocumentService.GetAll(new FileFindWhereParam() { Approved_By_Supervisor_DOD_ID = model.Approved_By_Supervisor_DOD_ID, Document_Type = model.Document_Type, Personnel_DOD_ID = model.Personnel_DOD_ID, Rank = model.Rank });
            //foreach result, add to a result card list item in another view model
            List<SearchResultViewModel> results = new List<SearchResultViewModel>();
            foreach (var result in allFiledDocs)
            {
                SearchResultViewModel res = new SearchResultViewModel();
                res.document_name = result.DOCUMENT_NAME;
                var owner = _PersonnelService.Get(result.PERSONNEL_OWNER);
                res.document_owner_name = owner.LAST_NAME + ", " + owner.FIRST_NAME + " " + owner.MIDDLE_NAME[0] + ".";
                res.Is_Signed = result.IS_SIGNED;
                res.LinkedPermit = result.PERMIT_GUID;
                res.filed_document_guid = result.FILLED_DOCUMENT_GUID;
                results.Add(res);
            }
            return View("Results", results);

        }
        [HttpGet]
        public IActionResult Results(List<SearchResultViewModel> model)
        {
            return View(model);
        }
        [HttpGet]
        public IActionResult GetPermit(Guid permit_guid)
        {
            //return the model
            return View();
        }
        [HttpGet]
        public IActionResult RequestSignature(string id)
        {
            var doc = _FileDocumentService.Get(new Guid(id));
            var owner = _PersonnelService.Get(doc.PERSONNEL_OWNER);

            string Username = "ce2381cf-5b03-447c-b6c9-5ebba8572212";
            string Password = "[*]Balcony711";
            string IntegrationKey = "a9d661a1-c751-40fa-9fc5-4b1a5865b08b";
            string filepath = Path.Combine(_HostingEnvironment.WebRootPath, "Templates\\" + doc.PDF_FILENAME);

            string basePath = "https://demo.docusign.net/restapi";

            ApiClient apiClient = new ApiClient(basePath);
            Configuration.Default.ApiClient = apiClient;

            string authHeader = "{\"Username\":\"" + Username + "\", \"Password\":\"" + Password + "\", \"IntegratorKey\":\"" + IntegrationKey + "\"}";
            Configuration.Default.AddDefaultHeader("X-DocuSign-Authentication", authHeader);

            AuthenticationApi authApi = new AuthenticationApi();
            LoginInformation loginInfo = authApi.Login();
            string accountID = loginInfo.LoginAccounts[0].AccountId;
            MemoryStream ms = new MemoryStream();
            PDFStampTemplates.Stamp(filepath, ms, owner);
            byte[] fileBytes = ms.ToArray();
            ms.Dispose();
            EnvelopeDefinition enDef = new EnvelopeDefinition();

            enDef.EmailSubject = "[C# DocuSign Sig Request]";

            DocuSign.eSign.Model.Document document = new DocuSign.eSign.Model.Document();
            document.DocumentBase64 = Convert.ToBase64String(fileBytes);
            document.Name = doc.DOCUMENT_NAME;
            document.DocumentId = "1";

            enDef.Documents = new List<DocuSign.eSign.Model.Document>();
            enDef.Documents.Add(document);

            Signer signer = new Signer();
            signer.Email = "mitchell@marshhome.net";
            signer.Name = "Mitchell";
            signer.RecipientId = "1";
            signer.ClientUserId = owner.PERSONNEL_ID.ToString();

            signer.Tabs = new Tabs();
            signer.Tabs.SignHereTabs = new List<SignHere>();
            SignHere signHere = new SignHere();
            signHere.DocumentId = "1";
            signHere.PageNumber = "1";
            signHere.RecipientId = "1";
            signHere.XPosition = "300";
            signHere.YPosition = "170";
            signer.Tabs.SignHereTabs.Add(signHere);

            enDef.Recipients = new Recipients();
            enDef.Recipients.Signers = new List<Signer>();
            enDef.Recipients.Signers.Add(signer);
            enDef.Status = "sent";

            EnvelopesApi envelopesApi = new EnvelopesApi();
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(accountID, enDef);

            RecipientViewRequest viewOptions = new RecipientViewRequest()
            {
                ReturnUrl = "https://localhost:44372/api/Signed/?id=" + doc.FILLED_DOCUMENT_GUID,
                ClientUserId = doc.PERSONNEL_OWNER.ToString(),
                AuthenticationMethod = "email",
                UserName = enDef.Recipients.Signers[0].Name,
                Email = enDef.Recipients.Signers[0].Email
            };
            ViewUrl recipientView = envelopesApi.CreateRecipientView(accountID, envelopeSummary.EnvelopeId, viewOptions);
            Console.WriteLine("ViewUrl:\n{0}", JsonConvert.SerializeObject(recipientView));

            //System.Diagnostics.Process.Start(recipientView.Url);

            return Redirect(recipientView.Url);
        }
        [HttpGet]
        public IActionResult GetDocument(string filed_document_guid)
        {
            var doc = _FileDocumentService.Get(new Guid(filed_document_guid));
            var owner = _PersonnelService.Get(doc.PERSONNEL_OWNER);
            string filepath = Path.Combine(_HostingEnvironment.WebRootPath, "Templates\\" + doc.PDF_FILENAME);


            using (MemoryStream ms = new MemoryStream())
            {
                PDFStampTemplates.Stamp(filepath, ms, owner);
                return new FileStreamResult(new MemoryStream(ms.ToArray()), "application/pdf");
               
            }
           
                

        }
        [HttpGet]
        public IActionResult Signed()
        {
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
        [HttpGet, Route("AddNewTemplate")]
        public IActionResult AddNewTemplate()
        {
            //DOCUMENT_DATA doc = new DOCUMENT_DATA();
            //doc.DOCUEMNT_GUID = new Guid();
            //doc.DOCUMENT_NAME = "OF_345.pdf";
            //doc.REQUIRES_SIGNATURE = true;
            //_DocumentService.Add(doc, HttpContext.User.Identity.Name);
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public struct DocumentRequest
        {
            public string doc_url { get; set; }
        }
        [HttpGet]
        public JsonResult GetBasicInformation(string guid)
        {
            DocumentRequest req = new DocumentRequest();
            req.doc_url = Path.Combine(_HostingEnvironment.WebRootPath, "Documents/NAVMC_10694.pdf");
            return Json(req);
        }
    }
}
