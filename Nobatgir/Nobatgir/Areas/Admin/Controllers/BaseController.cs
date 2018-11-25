﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Nobatgir.Services;
using Microsoft.AspNetCore.Mvc.Filters;
using Nobatgir.Model;

namespace Nobatgir.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BaseController : Controller
    {
        #region Controller
        protected Type type;

        protected readonly Repository repository;
        public BaseController(Repository repository)
        {
            this.repository = repository;
        }
        #endregion

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            // اضافی
            //var ControllerName = new Regex("[.](\\w+)Controller").Match(base.ToString()).Groups[1].Value;
            ViewBag.ReturnURL = Url.Action("Index", this.ControllerContext.ActionDescriptor.ControllerName);
        }

        public virtual IActionResult Details(int? id, int pageNumber, string searchString)
        {
            if (id == null)
                return NotFound();

            var row = this.repository.GetRow(id, this.type);
            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Details });
        }

        public virtual IActionResult Create(string ReturnURL)
        {
            ViewBag.ReturnURL = ReturnURL;
            return View(new DetailsViewModel<BaseClass> { ActionType = ActionTypes.Edit });
        }

        public virtual IActionResult Edit(int? id, string ReturnURL)
        {
            var row = this.repository.GetRow(id, this.type);
            if (row == null)
            {
                return NotFound();
            }
            ViewBag.ReturnURL = ReturnURL;

            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Edit });
        }

        public virtual IActionResult Delete(int? id, string ReturnURL)
        {
            var row = this.repository.GetRow(id, this.type);
            if (row == null)
            {
                return NotFound();
            }

            ViewBag.ReturnURL = ReturnURL;
            return View(new DetailsViewModel<BaseClass> { Row = row, ActionType = ActionTypes.Delete });
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual IActionResult DeleteConfirmed(int id, string ReturnURL)
        {
            var row = this.repository.GetRow(id, type);
            this.repository.DeleteRow(row);
            return RedirectToLocal(ReturnURL);
        }

        public virtual IActionResult RedirectToLocal(string ReturnURL)
        {
            if (Url.IsLocalUrl(ReturnURL))
            {
                return Redirect(ReturnURL);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
    }
}
