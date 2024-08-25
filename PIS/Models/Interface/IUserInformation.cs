using Microsoft.AspNetCore.Mvc;

namespace PIS.Models.Interface
{
    public interface IUserInformation
    {
        UserInformationViewModel Model { get; set; }
        IActionResult Register();
        bool Login(string userName, string password);
    }
}
