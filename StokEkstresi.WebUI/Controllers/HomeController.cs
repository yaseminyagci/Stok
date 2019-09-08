using StokEkstresi.WebUI.Models.DataTableRequest;
using StokEkstresi.WebUI.Models.DataTableResponse;
using StokEkstresi.WebUI.Models.Response;
using StokEkstresi.Domain.WebUI.Filter;
using StokEkstresi.Service;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace StokEkstresi.WebUI.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly StokEkstresiService _StokEkstre;
       
        public HomeController()
        {
         _StokEkstre = new StokEkstresiService();
      
        }
        // GET: HotelDefinition
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult StokEkstre()
        {
            return View();
        }
        public JsonResult GetStokDefinitionList(DataTableRequest<STKFilter> model)
        {
            var page = model.start;
            var rowsPerPage = model.length;

            var filteredData = _StokEkstre.GetAllStokDefinition(model.FilterRequest);
            var gridPageRecord = filteredData.Data.Skip(page).Take(rowsPerPage).ToList();

            DataTablesResponse tableResult = new DataTablesResponse(model.draw, gridPageRecord, filteredData.Data.Count, filteredData.Data.Count);

            return Json(tableResult, JsonRequestBehavior.AllowGet);
        }
        


    }
}