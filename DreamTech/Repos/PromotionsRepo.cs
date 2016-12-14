using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class PromotionsRepo
    {
        public tbl_PromoCode GetPromoById(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from t in context.tbl_PromoCode where t.promo_id == id select t).SingleOrDefault();
            }
        }
    }
}