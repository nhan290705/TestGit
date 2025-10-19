using BaiLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiLab.ViewComponents
{
    public class RenderViewComponent:ViewComponent
    {
        private readonly List<MenuItem> MenuItems;

        public RenderViewComponent()
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem { Id = 1, Name = "Branches", Link = "Branches/List" },
                new MenuItem { Id = 2, Name = "Students", Link = "Students/List" },
                new MenuItem { Id = 3, Name = "Subjects", Link = "Subjects/List" },
                new MenuItem { Id = 4, Name = "Courses", Link = "Courses/List" },
                new MenuItem { Id = 5, Name = "Product", Link = "Courses/List" }
            };
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Có thể trả về view con để render menu
            return View("RenderLeftMenu", MenuItems);
        }
    }
}
