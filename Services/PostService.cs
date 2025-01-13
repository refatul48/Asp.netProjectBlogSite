using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Blogger.Data;
using Blogger.Models;

namespace Blogger.Services
{
    public class PostService
    
    {
        private readonly AppDbContext  _dbContext;

        // Constructor injector
        public PostService (AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // public static List<Post> posts {get;set;}
   
        // static data dewa hoiche 
        public List<Post> GetAllPost()
        {
            // posts = new List<Post> ()
         
            // {
            //     new Post()
            //     {
            //         Id=1,
            //         Title= "This is Post BlogSite Title",
            //         Content = " This is Content is the Bangladesh Futere ",
            //         CatagoryId = 1,
            //         Status = Enums.Status.Default,
            //         Slug = "This_is_Psot_BlogSite_Title",


            //     },
            //     new Post()
            //     {
            //         Id=1,
            //         Title= "This is Post BlogSite Title",
            //         Content = " This is Content is the Bangladesh Futere ",
            //         CatagoryId = 1,
            //         Status = Enums.Status.Draft,
            //         Slug = "This_is_Psot_BlogSite_Title",


            //     },
            //     new Post()
            //     {
            //         Id=1,
            //         Title= "This is Post BlogSite Title",
            //         Content = " This is Content is the Bangladesh Futere ",
            //         CatagoryId = 1,
            //         Status = Enums.Status.Default,
            //         Slug = "This_is_Psot_BlogSite_Title",


            //     },
            //     new Post()
            //     {
            //         Id=1,
            //         Title= "This is Post BlogSite Title",
            //         Content = " This is Content is the Bangladesh Futere ",
            //         CatagoryId = 1,
            //         Status = Enums.Status.Published,
            //         Slug = "This_is_Psot_BlogSite_Title",


            //     },
            //     new Post()
            //     {
            //         Id=1,
            //         Title= "This is Post BlogSite Title",
            //         Content = " This is Content is the Bangladesh Futere ",
            //         CatagoryId = 1,
            //         Status = Enums.Status.Default,
            //         Slug = "This_is_Psot_BlogSite_Title",


            //     },
            //     new Post()
            //     {
            //         Id=1,
            //         Title= "This is Post BlogSite Title",
            //         Content = " This is Content is the Bangladesh Futere ",
            //         CatagoryId = 1,
            //         Status = Enums.Status.Default,
            //         Slug = "This_is_Psot_BlogSite_Title",


            //     },
            // };
            // return posts;

            return _dbContext.Posts.ToList();
        }   

        
        public  void AddPost(Post post)
        {
            if(post!= null)
            _dbContext.Posts.Add(post);


        }
    }

}