using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using YoutubeBlog.Entity.DTOs.Article;
using YoutubeBlog.Service.Services.Abstractions;
using YoutubeBlog.Service.Services.Concrete;

namespace YoutubeBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        public ArticleController(IArticleService articleService, ICategoryService categoryService , IMapper mapper)
        {
            this._articleService = articleService;
            this.categoryService = categoryService;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await _articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDto { Categories = categories });
        }

        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {
            await _articleService.CreateArticleAsync(articleAddDto);
            RedirectToAction("Index", "Article", new { Area = "Admin" });


            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDto { Categories = categories });
        }
        //buraya don hatalı olabilirartic
        [HttpGet]
        public async Task<IActionResult> Update(Guid articleId)
        {
            var article = await _articleService.GetArticleWithCategoryNonDeletedAsync(articleId);
            var categories = await categoryService.GetAllCategoriesNonDeleted();

            var articleUpdateDto = mapper.Map <ArticleUpdateDto>(article);

            return View(articleUpdateDto);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
        {
            await _articleService.UpdateArticleAsync(articleUpdateDto);
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            articleUpdateDto.Categories = categories;
            return View(articleUpdateDto);
           
        }

        public async Task<IActionResult> Delete(Guid articleId)
        {
            await _articleService.SafeDeleteArticleAsync(articleId);

            return RedirectToAction("Index", "Article", new { Area = "Admin" });

        }



    }

}
