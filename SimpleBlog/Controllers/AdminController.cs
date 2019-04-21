using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleBlog.Bll.Abstract;
using SimpleBlog.Entities;
using SimpleBlog.Models;

namespace SimpleBlog.Controllers
{
    public class AdminController : Controller
    {
        private IPostService _postService;
        private ICategoryService _categoryService;
        private IAuthorService _authorService;

        public AdminController(IPostService postService, ICategoryService categoryService, IAuthorService authorService)
        {
            _postService = postService;
            _categoryService = categoryService;
            _authorService = authorService;
        }

        public IActionResult Index(int postId)
        {
            var posts = _postService.GetList();
            PostListView model = new PostListView
            {
                Posts = posts
            };
            return View(model);
        }

        public ActionResult Add()
        {
            var model = new PostAddViewModel()
            {
                Post = new Post(),
                Categories = _categoryService.GetList(),
                Authors = _authorService.GetList()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Post post)
        {
            if (ModelState.IsValid)
            {
                _postService.Add(post);
                TempData.Add("message", "Post başarıyla eklendi.");
            }

            return RedirectToAction("Add");
        }

        public ActionResult Update(int postId)
        {
            var model = new PostUpdateViewModel()
            {
                Post = _postService.GetById(postId),
                Categories = _categoryService.GetList(),
                Authors = _authorService.GetList()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Post post)
        {
            if (ModelState.IsValid)
            {
                _postService.Update(post);
                TempData.Add("message", "Post başarıyla güncellendi.");
            }

            return RedirectToAction("Update");
        }

        public ActionResult Delete(int postId)
        {
            _postService.Delete(postId);
            TempData.Add("message", "Post başarıyla silindi.");
            return RedirectToAction("Index");

        }
        
    }
}