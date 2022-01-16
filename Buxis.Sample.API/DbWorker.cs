using Buxis.Sample.Infrastructure;
using Microsoft.Extensions.Hosting;

namespace Buxis.Sample.API
{
    public class DbWorker : IHostedService
    {
        private readonly IServiceProvider provider;

        public DbWorker(IServiceProvider provider)
        {
            this.provider = provider;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = provider.CreateScope();
            var db = scope.ServiceProvider.GetService<BuxiDbContext>();
            db.Database.EnsureCreated();

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
