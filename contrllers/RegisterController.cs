using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Elibrary3.Models;

namespace Elibrary3.contrllers
{
    public class RegisterController : Controller
    {
        private readonly ModelContext _Context;
     public RegisterController (ModelContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

       public IActionResult Save(ELVM obj)
        {
            //if (ModelState.IsValid)
            {
                try
                {
                    int SeqMax = _Context.ElStudentMsts.Select(x => x.SlNo).DefaultIfEmpty(0).Max();
                    SeqMax += 1;
                    obj.ELStudentMstsObj.SlNo = SeqMax;

                    _Context.Add(obj.ELStudentMstsObj);
                    _Context.SaveChanges();
                    return RedirectToAction("Index","Login");
                }
               catch (Exception ex)
                {
               
                }

            }
            return View("Index");
        }
      
    }
}