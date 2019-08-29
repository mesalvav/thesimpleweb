using System;
using Xunit;
using simpleweb.Models;
using simpleweb.Controllers;


namespace simpleweb.Test
{
    public class UnitTest1
    {
        SampleModel sampleModel = new SampleModel();
        [Fact]
        public void Test1()
        {
            var returnValue = sampleModel.MyName;
            Assert.Equal("Mario", returnValue);
        }

        HomeController hController = new HomeController();

        [Fact]
        public void apitest()
        {
            var returnValue = hController.Apinono();
            Assert.Equal("noApi", returnValue);
        }
    }
}
