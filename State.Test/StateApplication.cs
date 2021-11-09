using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;

namespace State.Api.Tests
{
    internal class StateApplication : WebApplicationFactory<Program>
    {
        private readonly string _environment;

        public StateApplication(string environment = "Development")
        {
            _environment = environment;
        }

        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.UseEnvironment(_environment);
            builder.ConfigureServices(services => { });

            return base.CreateHost(builder);
        }
    }
}