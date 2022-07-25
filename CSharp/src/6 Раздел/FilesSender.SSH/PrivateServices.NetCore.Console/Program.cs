using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SecuredServices.Core.Console.Data;
using SecuredServices.Core.Console.Models;
using SecuredServices.Core.Console.Roles;
using SecuredServices.Core.Console.SecurityValidators;
using SecuredServices.Core.Console.Services;
using SecuredServices.Core.Console.Services.Arguments;
using System;
using System.Linq;

namespace SecuredServices.Core.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Stated");

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(x =>
                {
                    x.AddTransient<EntityProtector<Client>, ClientSecurityValidator>();
                    x.AddTransient<IClientsService, ClientsService>();
                    x.AddTransient<IClientsModeratorService, ClientsService>();
                    x.AddSingleton<ClientsStorage>();
                    x.AddSingleton<UniversalClientsService>();
                }).Build();

            var scope = host.Services.CreateScope();
            var storage = scope.ServiceProvider.GetService<ClientsStorage>();
            var clientsService = scope.ServiceProvider.GetService<IClientsService>();
            
            // Чиста для всех, но есть EntityProtector - все четко
            var currentClient = storage.Clients.Last().Clone();
            currentClient.Name = "edit-by-universal";
            var universalService = scope.ServiceProvider.GetService<UniversalClientsService>();
            universalService.Edit(currentClient);

            // Чиста для всех, но есть EntityProtector - ошибка доступа
            currentClient = storage.Clients.Last().Clone();
            currentClient.Name = "edit-by-universal";
            currentClient.Role = SystemRole.Manager;
            universalService.Edit(currentClient);

            System.Console.WriteLine("End");
        }
    }
}
