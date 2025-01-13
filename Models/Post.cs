using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Blogger.Enums;

namespace Blogger.Models
{
    public class Post
    {
        public int Id {get;set;}
        public string Media {get;set;}
        public string Title {get;set;}
        public string Content {get;set;}
        public string Slug {get;set;}
        public DateTime CreateAT {get;set;}
        public DateTime UpdateAt {get;set;}
        public DateTime PublishedAt {get;set;}

        public Status Status {get;set;}
        public int CatagoryId {get;set;}
        public int UserId {get;set;}

    public Post()
    {
        CreateAT = DateTime.UtcNow;
        UpdateAt = DateTime.UtcNow;
        PublishedAt = DateTime.UtcNow;
        Media = "~/Images/Post/default-post.png";


    }


    }
}