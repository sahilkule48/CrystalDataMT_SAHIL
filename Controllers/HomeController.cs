using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using CrystalDataMT_SAHIL.Models;

using CrystalDataMT_SAHIL.Models;

namespace CrystalDataMT_SAHIL.Controllers
{
    public class HomeController : Controller
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        // GET: Home
        [HttpGet]
        public ActionResult Home()
        {
            String sql = "Select '' Srno,h.Invoice_No,h.InvoiceDate,p.Party_Name,h.Totalamount,'' as 'User' from DOCHDR h,PARTY_MASTER p where h.party_id=p.party_id order by h.totalamount";
            dt = Models.Mod_Connection.returndata(sql);
            return View(dt);
        }
    }
}