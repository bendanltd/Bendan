﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BenDan.Core.Entities;
using BenDan.Core.Interfaces;
using BenDan.Infrastructure.Database;
using BenDan.Infrastructure.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BenDan.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PostController(
            IPostRepository postRepository, 
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _postRepository = postRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var posts = await _postRepository.GetAllPosts();

            var postResources = _mapper.Map<IEnumerable<Post>, IEnumerable<PostResource>>(posts);
       
            return Ok(postResources);
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var newpost = new Post
            {
                Author = "笨蛋",
                Body = "23123333333333333123",
                Title = "Title A",
                LastModified = DateTime.Now
            };

            _postRepository.AddPost(newpost);
             await _unitOfWork.SaveAsync();
            return Ok();
        }
    }
}