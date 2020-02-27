using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SugarBItApplication2.Models;


namespace SugarBItApplication2.Services
{
    public class AuctionsServices
    {


        private AuctionsRepositry Actionsrepor = new AuctionsRepositry();


        public bool CreateAuction(Auctions bt)
        {
            return Actionsrepor.Create(bt);


        }

       

        public bool UpdateAuction(int id,Auctions bt)     // made by me 
        {
            return Actionsrepor.Update(id,bt);


        }


        public bool DeleteAuction(int id, Auctions bt)     // made by me 
        {
            return Actionsrepor.Delete(id, bt);


        }

    }
}
