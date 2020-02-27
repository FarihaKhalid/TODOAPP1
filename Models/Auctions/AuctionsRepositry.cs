using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SugarBItApplication2.Models
{
    public class AuctionsRepositry
    {

        private SugerBidAppContext _context = new SugerBidAppContext();




        public bool Create(Auctions bt)
        {

            if (bt != null)
            {
                bt.CreatedDate = System.DateTime.Now;
                _context.Auctions.Add(bt);
                _context.SaveChanges();
            }
            return true;

        }

        public bool Update(int id, Auctions ac)    //made by me 
        {
            var cc = _context.Auctions.Find(id);
            if (cc != null)
            {
                cc.ModifiedDate = System.DateTime.Now;
                cc.AuctionName = ac.AuctionName;
                _context.SaveChanges();
            }
            return true;
        }


        //DElet fuction IN REPO 
        public bool Delete(int id, Auctions ac)    
        {
            var cc = _context.Auctions.Find(id);
            if (cc != null)
            {
                cc.ModifiedDate = System.DateTime.Now;
                cc.AuctionName = ac.AuctionName;
                cc.AuctionName = "";
                _context.SaveChanges();
            }
            return true;
        }





    }
}
