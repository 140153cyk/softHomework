using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly OrderContext db;

        public OrderController(OrderContext context)
        {
            db = context;
        }

        [HttpPost]
        public ActionResult<Order> AddOrder(Order newOrder)
        {
            try
            {
                newOrder.OrderGuest = null;
                foreach (OrderDetail detail in newOrder.detailList)
                {
                    detail.product = null;
                }
                db.Orders.Add(newOrder);
                db.SaveChanges();
            }
            catch (Exception e){
                return BadRequest(e.InnerException.Message);
            }
            
            return newOrder;
        }

        [HttpGet]
        //Get全部的Order
        public ActionResult<List<Order>> GetOrder()
        {
            return db.Orders.Include(o=>o.detailList)
                .ThenInclude(d=>d.product)
                .Include("OrderGuest")
                .ToList();
        }

        //Get指定id的Order
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(long id)
        {
            Order order = db.Orders.Include(o => o.detailList)
                .ThenInclude(d => d.product)
                .Include("OrderGuest")
                .FirstOrDefault(o => o.Id == id);
            if (order == null) return NotFound();
            return order;
        }
        //Get指定客户的Order
        [HttpGet("GuestQuery")]
        public ActionResult<List<Order>> GetOrder(string Guest)
        {
            var query= db.Orders.Include(o => o.detailList)
                .ThenInclude(d => d.product)
                .Include("OrderGuest")
                .Where(o => o.OrderGuest.Name==Guest)
                .ToList();
            if (query.Count == 0) return NotFound();
            return query;
        }

        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(long id)
        {
            try
            {
                var order = db.Orders.Include(o => o.detailList)
                .FirstOrDefault(o => o.Id == id);
                if (order != null)
                {
                    order.OrderGuest = null;
                    foreach (OrderDetail detail in order.detailList)
                    {
                        detail.product = null;
                    }
                    db.Orders.Remove(order);
                   db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
        [HttpPut("{id}")]
        public ActionResult<Order> UpdateOrder(long id,Order order)
        {
            if (id != order.Id)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                order.OrderGuest = null;
                foreach(OrderDetail detail in order.detailList)
                {
                    detail.product = null;
                }
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

    }

}
