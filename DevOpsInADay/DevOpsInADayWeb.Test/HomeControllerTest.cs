using DevOpsInADayWeb.Controllers;
using DevOpsInADayWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;

namespace DevOpsInADayWeb.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void ContactTest()
        {
            var controller = new HomeController();

            var result = controller.Contact();

            var viewResult = Assert.IsType<ViewResult>(result);

            Assert.Equal("Your contact page.", viewResult.ViewData["Message"]);
        }

        [Fact]
        public void AboutTest()
        {
            var controller = new HomeController();

            var result = controller.About();

            var viewResult = Assert.IsType<ViewResult>(result);

            Assert.Equal("Your application description page.", viewResult.ViewData["Message"]);
        }

        [Fact]
        public void IndexTest()
        {
            var controller = new HomeController();

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);

            var model = Assert.IsType<List<Event>>(viewResult.Model);

            Assert.Equal(1, model.Count);
        }

        //[Fact]
        //public void PrivacyTest()
        //{
        //    var controller = new HomeController();

        //    var result = controller.Privacy();

        //    Assert.IsType<ViewResult>(result);
        //}

        //[Fact]
        //public void ErrorTest()
        //{
        //    var controller = new HomeController();
            
        //    var result = controller.Error();

        //    var viewResult = Assert.IsType<ViewResult>(result);

        //    var model = Assert.IsType<ErrorViewModel>(viewResult.Model);

        //    Assert.Null(model.RequestId);

        //    Assert.False(model.ShowRequestId);
        //}
    }
}
