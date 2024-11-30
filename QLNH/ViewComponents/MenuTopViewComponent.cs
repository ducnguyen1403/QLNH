using Microsoft.AspNetCore.Mvc;
using QLNH.Models;

namespace QLNH.ViewComponents
{
    public class MenuTopViewComponent : ViewComponent
    {
        private readonly DoAnPtudwContext _context;

        public MenuTopViewComponent(DoAnPtudwContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TblMenus.Where(m => (bool)m.IsActive).
                OrderBy(m => m.Position).ToList();
            return await Task.FromResult<IViewComponentResult>(View(items));
        }
    }
}
