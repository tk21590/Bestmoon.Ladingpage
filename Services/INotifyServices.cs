using AspNetCoreHero.ToastNotification.Abstractions;
using BestVia.Models;

namespace BestViaCustomer.LandingPage.Services
{
    public interface INotifyServices
    {
        void CustomWarning(string content);
        void CustomSuccess(string content);
        void CustomDanger(string content);
    }
    partial class NotifyServices : INotifyServices
    {
        private readonly INotyfService _notyf;
        public NotifyServices(INotyfService notyf)
        {
            _notyf = notyf;
        }
        public void CustomWarning(string content)
        {
            _notyf.Custom(content, 10, "#FFBB33", "fa fa-shield");
        }

        public void CustomSuccess(string content)
        {
            _notyf.Success($"{content}");
        }
        public void CustomDanger(string content)
        {
            _notyf.Error($"{content}");
        }
    }
}
