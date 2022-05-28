using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PrivateServices.NetCore.Console.Data;
using PrivateServices.NetCore.Console.Models;
using PrivateServices.NetCore.Console.Roles;
using PrivateServices.NetCore.Console.SecurityValidators;
using PrivateServices.NetCore.Console.Services;
using PrivateServices.NetCore.Console.Services.Arguments;
using System;
using System.Linq;

namespace PrivateServices.NetCore.Console
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

            // Чиста для клиентов
            var clientsService = scope.ServiceProvider.GetService<IClientsService>();
            //var editArgument = new EditClientArgument()
            //{
            //    EditedName = "edited-name"
            //};
            //clientsService.Edit(editArgument);

            //// Чиста для модеров
            //EditClientModeratorArgument editModeratorArgument = new EditClientModeratorArgument()
            //{
            //    EditedName = "edited-name",
            //    EditedRole = SystemRole.Admin
            //};
            //var clientsModeratorService = scope.ServiceProvider.GetService<IClientsModeratorService>();
            //clientsModeratorService.Edit(editModeratorArgument);
            //clientsModeratorService.DeleteById(editModeratorArgument.Id);

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
