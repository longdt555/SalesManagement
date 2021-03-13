﻿using Lib.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YDManagement.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YDManagement.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = new JResultHelper();
            result.SetStatusSuccess();
            var data = _productService.GetAll();
            result.SetData(data);
            return Ok(result);
        }


        // GET api/<ProductController>/5
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var data = _productService.GetById(id);
            return Ok(data);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}