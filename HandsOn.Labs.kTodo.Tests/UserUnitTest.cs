using HandsOn.Labs.kTodo.Application.Interfaces.CQRS;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace HandsOn.Labs.kTodo.Tests
{
    public class UserUnitTest
    {
        private static WebApplicationFactory<Program> _factory;
        private static IServiceScopeFactory _scopeFactory;
        public UserUnitTest()
        {
            _factory = new WebApplicationFactory<Program>();
            _scopeFactory = _factory.Services.GetRequiredService<IServiceScopeFactory>();
        }

        [Fact]
        public void Test1()
        {
            using var scope = _scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetService<IUserQueryService>();

            Assert.NotNull(context);
        }
    }
}