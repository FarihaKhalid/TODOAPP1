using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SugarBItApplication2.Models;

namespace SugarBItApplication2.Models
{
    public class BatchRepository
    {
        private SugerBidAppContext _context = new SugerBidAppContext();


 

        public bool Create(Batchs bt)
        {
          
                if (bt != null)
                {
                    
                    _context.Batchs.Add(bt);
                    _context.SaveChanges();
                }
                return true;

            }


        // UPDATE  FUNCTION IN REPOS

        public bool Update(int id, Batchs ac)    //made by me 
        {
            var cc = _context.Batchs.Find(id);
            if (cc != null)
            {
                
                cc.BatchName = ac.BatchName;
                _context.SaveChanges();
            }
            return true;
        }

        // DELETE  FUNCTION IN REPOS

        public bool Delete(int id, Batchs ac)    //made by me 
        {
            var cc = _context.Batchs.Find(id);
            if (cc != null)
            {
               
                cc.BatchName = ac.BatchName;
                cc.BatchName = "";
                _context.SaveChanges();
            }
            return true;
        }



    }



}


