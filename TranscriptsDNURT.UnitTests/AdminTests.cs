using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Transcript.WebUI.Controllers;
using TranscriptDNURT.WebUI.Models;
using TranscriptsDNURT.Domain.Entities;
using TranscriptsDNURT.Domain.Interfaces;

namespace TranscriptsDNURT.UnitTests
{
    [TestClass]
    public class AdminTests
    {
        [TestMethod]
        public void User_Success_Authorize()
        {
            // Arrange (Организация)
            string expected = "AdminPanel";

            var mock = new Mock<IUserRepository>();

            mock.Setup(_ => _.Users).Returns(new List<User>
            {
                new User{Id = 1, Login = "L1", Password = "P1"},
                new User{Id = 2, Login = "L2", Password = "P2"},
                new User{Id = 3, Login = "L3", Password = "P3"},
                new User{Id = 4, Login = "L4", Password = "P4"},
                new User{Id = 5, Login = "L5", Password = "P5"}
            });

            LoginModel loginModel = new LoginModel
            {
                login = "L1",
                password = "P1"
            };

            AccountController controller = new AccountController(mock.Object);

            // Act (Действие)
            RedirectToRouteResult result = controller.Login(loginModel) as RedirectToRouteResult;

            // Assert (Утверждение)
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.RouteValues["action"]);
        }

        [TestMethod]
        public void User_Failed_Authorize()
        {
            // Arrange (Организация)
            string expected = "Index";

            var mock = new Mock<IUserRepository>();

            mock.Setup(_ => _.Users).Returns(new List<User>
            {
                new User{Id = 1, Login = "L1", Password = "P1"},
                new User{Id = 2, Login = "L2", Password = "P2"},
                new User{Id = 3, Login = "L3", Password = "P3"},
                new User{Id = 4, Login = "L4", Password = "P4"},
                new User{Id = 5, Login = "L5", Password = "P5"}
            });

            LoginModel loginModel = new LoginModel
            {
                login = "L6",
                password = "P6"
            };

            AccountController controller = new AccountController(mock.Object);

            // Act (Действие)
            RedirectToRouteResult result = controller.Login(loginModel) as RedirectToRouteResult;

            // Assert (Утверждение)
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.RouteValues["action"]);
        }
    }
}
