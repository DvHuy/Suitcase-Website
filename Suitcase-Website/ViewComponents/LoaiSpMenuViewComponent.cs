using Microsoft.AspNetCore.Mvc;
using Suitcase_Website.Models;
using Suitcase_Website.Repository;
namespace Suitcase_Website.ViewComponents
{
    public class LoaiSpMenuViewComponent : ViewComponent
    {
        private readonly ILoaiSpRepository _loaiSpRepository;

        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            _loaiSpRepository = loaiSpRepository;
        }

        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSpRepository.getAllLoaiSp().OrderBy(x => x.Loai);
            return View(loaisp);
        }
    }
}
