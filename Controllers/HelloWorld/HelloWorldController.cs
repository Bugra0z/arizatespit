using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web;

namespace MvcMovie.Controllers 
{ 
    public class HelloWorldController : Controller 
    { 
        // 
        // GET: /HelloWorld/ 
 
        public string Index() 
        { 
            return "This is my <b>default</b> action..."; 
        } 
 
        // 
        // POST: /HelloWorld/Welcome/ 
        [HttpGet]
        public string Welcome() 
        { 
            return "selam";
        }

        public string beyler()
        {
            return "selamlar";
        } 
    } 
}
