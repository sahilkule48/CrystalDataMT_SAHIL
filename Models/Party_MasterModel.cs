using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalDataMT_SAHIL.Models
{
    public class Party_MasterModel
    {
        public Int64 Party_ID { get; set; }

        public string Party_Name { get; set; }

        public Int64 ITEM_ID { get; set; }
        public String ITEM_Name { get; set; }
        public Int64 UOM_ID { get; set; }
        public String UOM_Name { get; set; }
        //public String AcCode { get; set; }
        //public String AcName { get; set; }
        //public String ProdCode { get; set; }
        //public String ProdName { get; set; }
        //public String DefaultUnit { get; set; }
        //public String BasicUnit { get; set; }
    }

}