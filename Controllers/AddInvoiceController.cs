using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using CrystalDataMT_SAHIL.Models;

namespace CrystalDataMT_SAHIL.Controllers
{
    public class AddInvoiceController : Controller
    {
        DataTable dt;
        // GET: AddInvoice
        [HttpGet]
        public ActionResult AddInvoice()
        {
            dt = new DataTable();
            string sql = "Select * from MAs_Account";
            dt = Models.Mod_Connection.returndata(sql);
            ViewBag.PartyList = ToSelectLists(dt, "AcCode", "AcName");
            return View();
        }
        [HttpGet]
        public ActionResult Load()
        {
            dt = new DataTable();
            string sql = "Select * from PARTY_MASTER";
            dt = Models.Mod_Connection.returndata(sql);
            ViewBag.PartyList = ToSelectLists(dt, "Party_Id", "Party_Name");
            sql = "Select * from ITEM_MASTER";
            dt = Models.Mod_Connection.returndata(sql);
            ViewBag.ItemList = ToSelectLists(dt, "ITEM_Id", "ITEM_Name");
            ViewBag.ItemList1 = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(ToSelectLists(dt, "ITEM_Id", "ITEM_Name"));
            sql = "Select * from UOM";
            dt = Models.Mod_Connection.returndata(sql);
            ViewBag.UOMList = ToSelectLists(dt, "UOM_Id", "UOM_Name");
            ViewBag.UOMList1 = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(ToSelectLists(dt, "UOM_Id", "UOM_Name"));
            ViewBag.message = "Hello";
            return View();

        }

        [NonAction]
        public SelectList ToSelectLists(DataTable dataTable,string valueField,string textField)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(new SelectListItem()
                {
                    Text = row[textField].ToString(),
                    Value=row[valueField].ToString()
                }
                    ) ;
            }

            return new SelectList(list, "Value", "Text");
        }
        //[HttpPost]
        //public string submit()
        //{
        //    return;
        //}
    }
}