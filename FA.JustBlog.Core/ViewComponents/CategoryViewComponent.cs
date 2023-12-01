using FA.JustBlog.Core.Service.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Core.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly IUnitOfWork unitOfWork;
        public CategoryViewComponent(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IViewComponentResult Invoke()
        {
            return View(unitOfWork.categoryRepository.GetAll());
        }
    }
}
