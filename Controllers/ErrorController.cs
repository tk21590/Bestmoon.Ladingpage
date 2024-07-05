using Microsoft.AspNetCore.Mvc;

namespace BestViaCustomer.LandingPage.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error/{status_code}")]
        public IActionResult HttpStatusCodeHandler(int status_code)
        {
            switch (status_code)
            {
                case 401:
                    ViewBag.ErrorMessage = "Bạn không đủ quyền !";
                    ViewBag.ErrorCode = status_code;
                    break;
                case 404:
                    ViewBag.ErrorMessage = "Không tìm thấy trang bạn cần tìm !";
                    ViewBag.ErrorCode = status_code;
                    break;
                case 500:
                    ViewBag.ErrorMessage = "Opp! Có lỗi xảy ra ,vui lòng reset trang hoặc quay lại sau!";
                    ViewBag.ErrorCode = status_code;
                    break;
                default:
                    break;
            }
            return View("Error");
        }
    }
}
