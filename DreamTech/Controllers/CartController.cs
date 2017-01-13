using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamTech.Controllers
{
    public class CartController : BaseController
    {
        // GET: Cart
        public ActionResult Index()
        {
            List<int?> list = (Session["CartItems"] as List<int?>) ?? new List<int?>();

            var repo = new Repos.ProductRepo();
            var prodList = repo.GetMutipleProducts(list);

            return View(prodList);
        }

        public ActionResult CheckOut(decimal? totalDue)
        {
            var isLogged = CheckLogin();

            if(isLogged == true)
            {
                List<int?> list = (Session["CartItems"] as List<int?>) ?? new List<int?>();

                var repo = new Repos.ProductRepo();
                var prodList = repo.GetMutipleProducts(list);

                SaveItems(prodList, totalDue);

                return View("Index", prodList);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public void SaveItems(List<console.Models.tblProduct> prodList , decimal? totalDue)
        {
            console.Models.tbl_CartItem item = new console.Models.tbl_CartItem();
            List<console.Models.tbl_CartItem> items = new List<console.Models.tbl_CartItem>();
            var repo = new Repos.CartItemRepo();

            string reference = prodList.Count().ToString();
            DateTime now = DateTime.Now;
            reference += "#" + now.Hour.ToString() + "/" + now.Minute + "/" + now.Second + "/" + now.Date;

            foreach (var product in prodList)
            {
                item.cart_ref = reference;
                item.product_id = product.product_id;
                item.quantity = 1;

                items.Add(item);
            }

            repo.SaveCartItems(items);

            CreateCart(totalDue, reference);
        }

        public void CreateCart(decimal? amount, string reference)
        {
            console.Models.tbl_Cart cart = new console.Models.tbl_Cart();
            console.Models.tbl_User user = new console.Models.tbl_User();
            console.Models.tbl_OrderStatus status = new console.Models.tbl_OrderStatus();
            console.Models.tbl_PromoCode promo = new console.Models.tbl_PromoCode();

            Models.LoginViewModel model = new Models.LoginViewModel();
            user = FindUser(model);

            var repo = new Repos.CartRepo();

            cart.cart_ref       = reference;
            cart.cart_total     = amount;

            repo.SaveCart(cart);

            CreateOrder(cart, user, promo, status);
        }

        public void CreateOrder(console.Models.tbl_Cart cart, console.Models.tbl_User user, console.Models.tbl_PromoCode promo, console.Models.tbl_OrderStatus status)
        {
            console.Models.tbl_Order order = new console.Models.tbl_Order();
            var repo = new Repos.OrderRepo();
            var statRepo = new Repos.OrderStatusRepo();
            var userRepo = new Repos.UserRepo();
            var promoRepo = new Repos.PromotionsRepo();

            var statObject = statRepo.GetStatus(1);
            var userObject = userRepo.GetUserById(1);
            var promoObject = promoRepo.GetPromoById(1);

            order.user_id               = userObject.user_id;
            order.cart_ref              = cart.cart_ref;
            order.order_status_id       = statObject.status_id;
            order.delivery_address_id   = userObject.delivery_id;
            order.order_total           = cart.cart_total;
            order.promo_id              = promoObject.promo_id;

            repo.SaveOrder(order);

            RemoveProdsFromCart();
        }
    }
}