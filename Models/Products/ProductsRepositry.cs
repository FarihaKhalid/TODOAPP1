using SugarBItApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SugarBItApplication2.Models
{
    public class ProductsRepositry 
    {

        private SugerBidAppContext productrepos = new SugerBidAppContext();




        public bool Create(Products bt)
        {

            if (bt != null)
            {
                bt.CreatedDate = System.DateTime.Now;
    
                productrepos.Products.Add(bt);
                productrepos.SaveChanges();
            }
            return true;

        }
    }
}
