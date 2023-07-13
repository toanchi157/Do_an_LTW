using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DullStore.Models
{
    public class Category
    {
        public List<string> listdm { get; set; }
        public Category()
        {
            listdm = new List<string>();
            listdm.Add("Adidas ");
            listdm.Add("Nike");
            listdm.Add("Supreme ");
            listdm.Add("Jordan");
            listdm.Add("Puma");
            listdm.Add("Balenciaga");
        }
    }
}