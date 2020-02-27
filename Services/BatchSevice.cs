
using SugarBItApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SugarBItApplication2.Services
{
    public class BatchService
    {
        private BatchRepository batchrepor = new BatchRepository();


        public bool CreateBatch(Batchs bt)
        {
            return batchrepor.Create(bt);


        }



        public bool UpdateBatchs(int id, Batchs bt)     // made by me 
        {
            return batchrepor.Update(id, bt);


        }


        public bool DeleteBatchs(int id, Batchs bt)     // made by me 
        {
            return batchrepor.Delete(id, bt);


        }




    }
}





