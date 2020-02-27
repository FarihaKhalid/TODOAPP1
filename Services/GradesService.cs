
using System;

using SugarBItApplication2.Models;
using SugarBItApplication2.Models;

namespace SugarBItApplication2.Services
{
    public class GradesService
    {
        private GradesRepository gradesrepor = new GradesRepository();

        
        public bool CreateGrades(Grades bt)
        {
            return gradesrepor.Create(bt);


        }

        internal bool Create(Grades bt)
        {
            throw new NotImplementedException();
        }
    }
}



