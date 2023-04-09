using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Makeform.Models;
using System.IO;
namespace Makeform.Controllers
{
    public class MakeFormController : Controller
    {
        // GET: MakeForm
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult KetQua()
        {
            return View(SinhVien.dssinhvien);
        }
        [HttpPost]
        public ActionResult XuLy(SinhVien sv,HttpPostedFileBase filAnh)
        {
            if (ModelState.IsValid)
            {
              if (filAnh.ContentLength > 0 && filAnh != null )
            {
                //luu file 
                string hinhanh = Server.MapPath("/Data/");
                string duongdan = hinhanh + filAnh.FileName;
                filAnh.SaveAs(duongdan);
                sv.Anh = "/Data/" + filAnh.FileName;
            }     
                
            SinhVien.dssinhvien.Add(sv);return RedirectToAction("KetQua");
            }
           else
            {
                return RedirectToAction("XuLy");
            }
            
            
            
            



            
            
        }
        
    }
}