using BenDan.Core.Entities;
using BenDan.Core.Interfaces;
using BenDan.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BenDan.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        public readonly BaseContext _baseContext;

        public PostRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await _baseContext.Posts.ToListAsync();
        }

        public void AddPost(Post post)
        {
            _baseContext.Posts.Add(post);
        }

    }
}
