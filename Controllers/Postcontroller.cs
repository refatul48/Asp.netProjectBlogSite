using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Blogger.Data;
using Blogger.Models;
using Blogger.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Logging;

namespace Blogger.Controllers
{
  
    public class Postcontroller : Controller
    {
        private readonly AppDbContext _context;
        public Postcontroller (AppDbContext context)
        {
            _context = context;

        }
        // private PostService postService = new PostService();

        public IActionResult List()
        {
            var Posts = _context.Posts.ToList();

            return View(Posts);
        }

       
         
        public IActionResult Create()
        {
            return View();
            
        }

        [HttpPost]
        public IActionResult Create ( Post post)
        {
            if(post == null)
            {
               return BadRequest("Post data invalid");
            }
            // postService.AddPost(post);
            _context.Posts.Add(post);
            _context.SaveChanges();
            TempData["success"] = "post updated succes";
            return RedirectToAction("List");

        }

        public IActionResult Edit(int Id)
        {
            if(Id<0)
                 return BadRequest("Post not availble");
 
            Post post =_context.Posts.FirstOrDefault(X=>X.Id == Id);
            
            if(post == null)
            {
                return NotFound("post not found");
            }

    
            return View();
        

        }


    }
}