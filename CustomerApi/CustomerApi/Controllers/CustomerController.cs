using CustomerApi.DataAccess;
using CustomerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly BBDDContext context;
        public CustomerController(BBDDContext context)
        {
            this.context = context;
        }

            // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.CustomerModel.ToList());
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<CustomerController>/ 5
        [HttpGet("{id}", Name = "GetCustomer")]
        public ActionResult Get(int id)
        {
            try
            {
                var customer = context.CustomerModel.FirstOrDefault(cust => cust.IdCustomer == id);
                return Ok(customer);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<CustomerController>
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public ActionResult Post([FromBody] CustomerModel customer)
        {
            try
            {
                var gestor = context.CustomerModel.Add(customer);
                context.SaveChanges();
                return CreatedAtRoute("GetCustomer", new { id = customer.IdCustomer }, customer);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CustomerModel customer)
        {
            try
            {
                if ( customer.IdCustomer == id)
                {
                    context.Entry(customer).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetCustomer", new { id = customer.IdCustomer }, customer);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var customer = context.CustomerModel.FirstOrDefault(cust => cust.IdCustomer == id);
                if (customer != null)
                {
                    context.CustomerModel.Remove(customer);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
