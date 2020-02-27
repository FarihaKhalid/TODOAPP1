using SugarBItApplication2.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SugarBItApplication2.Services
{
    public class CompanysService
    {

        
        private CompanysRepositry comoanysrepor = new CompanysRepositry();



        public bool CreateCompanys(Companys bt)
        {

            return comoanysrepor.Create(bt);

        }

        public bool UpdateCompany(int id ,Companys bt )
            {
            return comoanysrepor.Update(id,bt);

        }

        public bool DeleteCompany(int id, Companys bt)
        {


            return comoanysrepor.Delete(id, bt);
        }
    }
}
