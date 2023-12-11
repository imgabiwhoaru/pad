﻿using Domain;
using System.Collections.Generic;

namespace DAL.Abstract
{
    public interface IPostRepository
    {
        IList<Post> GetPosts();

        void CreatePost(Post post);
    }
}
