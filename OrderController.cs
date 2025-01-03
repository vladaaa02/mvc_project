using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
        
        public OrderController(IOrderRepository repoService, Cart cartService) 
        {
            repository = repoService;
            cart = cartService;
        }


        public ViewResult Checkout() => View(new Order());


        [HttpPost]
        public IActionResult Checkout(Order order) 
        {
            if (cart.Lines.Count() == 0) 
            {
                ModelState.AddModelError("", "Izvinite, Vasa korpa je prazna!");
            }
            if (ModelState.IsValid) 
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                cart.Clear();
                return RedirectToPage("/Completed", new { orderId = order.OrderID });
            } else 
            {
                return View();
            }
        }
    }
}