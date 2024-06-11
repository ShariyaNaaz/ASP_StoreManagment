using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaptopApp_MVC.Models;
using LaptopDal;
using System.Data;


namespace LaptopApp_MVC.Controllers
{
    public class HomeController : Controller
    {
        LaptopDetailsDaL objDal = new LaptopDetailsDaL();
        DataTable dt;
        public ActionResult Index()
        {
            string mycmd = "select * from ProTB";
            dt = new DataTable();
            dt = objDal.SelectAll(mycmd);
            List<Laptop> list = new List<Laptop>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Laptop lap = new Laptop();
                lap.SrNo = Convert.ToInt32(dt.Rows[i]["SrNo"]);
                lap.LaptopName = dt.Rows[i]["LaptopName"].ToString();
                lap.Price = Convert.ToDouble(dt.Rows[i]["Price"]);
                lap.Url = dt.Rows[i]["Url"].ToString();
                lap.ZoomURL = dt.Rows[i]["ZoomUrl"].ToString();
                list.Add(lap);

            }
            return View(list);
        }

        public ActionResult EachProductDetails(Laptop l)
        {
            string mycmd = "Select l.SrNo,l.LaptopName,l.Price,l.Url,l.ZoomURL,ld.Features,ld.Model,ld.Color from ProTB l inner join Table_3 ld on l.SrNo=ld.LaptopId where l.SrNo=" + l.ID;
            dt = new DataTable();

            dt = objdal.SelactAll(mycmd);

            List<ProductDetails> list = new List<ProductDetails>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ProductDetails lap = new ProductDetails();
                lap.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                lap.LaptopId = Convert.ToInt32(dt.Rows[i]["LaptopId"]);
                lap.LaptopName = dt.Rows[i]["LaptopName"].ToString();
                lap.Model = dt.Rows[i]["Model"].ToString();

                lap.Features = dt.Rows[i]["Features"].ToString();

                lap.Color = dt.Rows[i]["Color"].ToString();





                list.Add(lap);

            }
            return View(list);

            public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}