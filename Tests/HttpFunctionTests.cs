using Functions;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using TNDStudios.Helpers.AzureFunctions.Testing.Factories;
using TNDStudios.Helpers.AzureFunctions.Testing.Mocks;
using Xunit;

namespace Tests
{
    public class HttpFunctionTests
    {
        [Fact]
        public void Example()
        {
            // Arrange
            ILogger logger = new TestLogger();
            IBinder binder = BinderFactory.CreateBinder();
            DefaultHttpRequest httpRequest = HttpFactory.CreateHttpRequest();

            // Act
            HttpStatusCode result = HttpFactory.GetHttpStatusCode(HttpFunction.Run(httpRequest, binder, logger).Result);

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, result);
        }
    }
}
