﻿using StokEkstresi.Core;
using StokEkstresi.WebUI.Models.Response;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace StokEkstresi.WebUI.Controllers
{
  
    public abstract class ControllerBase : Controller
    {
        public ControllerBase()
        {
        }

        public UIResponse UIResponse { get; set; }

        public JsonResult JSonModelStateHandle()
        {
            this.UIResponse = new UIResponse
            {
                ResultType = OperationResultType.Warn,
                Data = ModalStateErrorHandle(),
                Message = "ValidationErrors",
            };

            return Json(this.UIResponse, JsonRequestBehavior.AllowGet);
        }

        public IEnumerable<Errors> ModalStateErrorHandle()
        {
            IEnumerable<Errors> err = ModelState.Where(p => p.Value.Errors.Any())
                                                .GroupBy(g => g.Key)
                                                .Select(p => new Errors
                                                {
                                                    Key = p.Key,
                                                    ErrorMessages = p.SelectMany(c => c.Value.Errors.Select(d => d.ErrorMessage)).ToArray(),
                                                    Exceptions = p.SelectMany(c => c.Value.Errors.Select(d => d.Exception)).ToArray()
                                                });

            return err;
        }
    }
}