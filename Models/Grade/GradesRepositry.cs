using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SugarBItApplication2.Models;

namespace SugarBItApplication2.Models
{
    public class GradesRepository
    {
        private SugerBidAppContext _context = new SugerBidAppContext();




        public bool Create(Grades bt)
        {

            if (bt != null)
            {

                _context.Grades.Add(bt);
                _context.SaveChanges();
            }
            return true;

        }

    }



}

