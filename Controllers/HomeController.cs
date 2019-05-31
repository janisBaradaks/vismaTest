using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using visma_test.Models;

namespace visma_test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //mockup data simulating from db with limitation to 10 latest records ordered by date that are saved in list
            UserModel firstUser = new UserModel("A1", "Jānis", "Testeris");
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisUserLogin", "22222777", new System.DateTime(2011, 12, 25, 10, 30, 50)));
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisUserLogin", "22222777", new System.DateTime(2013, 12, 25, 10, 30, 50)));
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisUserLogin", "22222777", new System.DateTime(2012, 12, 25, 10, 30, 50)));
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisUserLogin", "22222777", new System.DateTime(2019, 12, 25, 10, 30, 50)));
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisUserLogin", "22222777", new System.DateTime(2011, 12, 24, 10, 30, 50)));
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisUserLogin", "22222777", new System.DateTime(2013, 12, 22, 10, 30, 50)));
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisAdminLogin", "27772777", new System.DateTime(2012, 12, 21, 10, 30, 50)));
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisAdminLogin", "27772777", new System.DateTime(2019, 12, 28, 10, 30, 50)));
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisAdminLogin", "27772777", new System.DateTime(2015, 12, 25, 10, 30, 50)));
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisAdminLogin", "27772777", new System.DateTime(2015, 12, 24, 10, 30, 50)));
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisAdminLogin", "27772777", new System.DateTime(2015, 12, 22, 10, 30, 50)));
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisAdminLogin", "27772777", new System.DateTime(2015, 12, 21, 10, 30, 50)));
            firstUser.UserDetailsModel.Add(new UserDetailsModel("JānisAdminLogin", "27772777", new System.DateTime(2015, 12, 28, 10, 30, 50)));

            firstUser.UserDetailsModel = firstUser.UserDetailsModel.OrderByDescending(x => x.timestamp).Take(10).ToList();

            UserModel secondtUser = new UserModel("A2", "Juris", "Developeris");
            secondtUser.UserDetailsModel.Add(new UserDetailsModel("JurisSuperAdmin", "12345678", new System.DateTime(2011, 12, 25, 10, 30, 50)));
            secondtUser.UserDetailsModel.Add(new UserDetailsModel("JurisMinAdmin", "12345678", new System.DateTime(2011, 12, 25, 10, 30, 50)));
            secondtUser.UserDetailsModel.Add(new UserDetailsModel("JurisSuperAdmin", "12345678", new System.DateTime(2011, 12, 25, 10, 30, 50)));
            secondtUser.UserDetailsModel.Add(new UserDetailsModel("JurisSuperAdmin", "12345678", new System.DateTime(2011, 12, 25, 10, 30, 50)));


            UserModel thirdUser = new UserModel("A3", "Pēteris", "Wizard");

            List<UserModel> userList = new List<UserModel>();
            userList.Add(firstUser);
            userList.Add(secondtUser);
            userList.Add(thirdUser);

            userList.ToList();

            return View(userList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
