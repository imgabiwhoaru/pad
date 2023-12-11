﻿using System;


namespace Domain
{
    public class Post
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}
