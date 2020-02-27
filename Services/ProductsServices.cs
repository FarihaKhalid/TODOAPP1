using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SugarBItApplication2.Models;

namespace SugarBItApplication2.Services
{
    public class ProductsServices
    {

        private ProductsRepositry productsrepor = new ProductsRepositry();


        public bool CreateProduct(Products bt)
        {
            return productsrepor.Create(bt);


        }

    }
}
