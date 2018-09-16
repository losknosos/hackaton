﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GetStartedDotnet.Models;
using System.Linq;
using System.Text.Encodings.Web;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GetStartedDotnet.Controllers
{
    [Route("api/[controller]")]
    public class VisitorsController : Controller
    {
        private readonly HtmlEncoder _htmlEncoder;
        private readonly VisitorsDbContext _dbContext;

        public VisitorsController(HtmlEncoder htmlEncoder, VisitorsDbContext dbContext = null)
        {
            _dbContext = dbContext;
            _htmlEncoder = htmlEncoder;
        }

        // GET: api/values
        [HttpGet]
        public JsonResult Get()
        {
            if (_dbContext == null)
            {
                return Json(null);
            }
            else
            {
                return Json(_dbContext.Visitors.ToList());
            }
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<string> Post([FromBody]Visitor visitor)
        {
            if (_dbContext != null)
            {
                _dbContext.Visitors.Add(visitor);
                _dbContext.SaveChanges();
            }

            return new string[] { _htmlEncoder.Encode(visitor.Name) };
        }
    }
}
