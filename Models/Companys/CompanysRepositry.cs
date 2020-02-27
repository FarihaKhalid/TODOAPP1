using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SugarBItApplication2.Models
{
    public class CompanysRepositry
    {
        private SugerBidAppContext _context = new SugerBidAppContext();




        public bool Create(Companys bt)
        {

            if (bt != null)
            {

                _context.Companys.Add(bt);
                _context.SaveChanges();
            }
            return true;

        }


        // UPDATE  FUNCTION IN REPOS

        public bool Update(int id, Companys ac)    //made by me 
        {
            var cc = _context.Companys.Find(id);
            if (cc != null)
            {

                cc.CompanyName = ac.CompanyName;
                _context.SaveChanges();
            }
            return true;
        }

        // DELETE  FUNCTION IN REPOS

        public bool Delete(int id, Companys ac)    //made by me 
        {
            var cc = _context.Companys.Find(id);
            if (cc != null)
            {

                cc.CompanyName = ac.CompanyName;
                cc.CompanyName = "";
                _context.SaveChanges();
            }
            return true;
        }




    }
}
