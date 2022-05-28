using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PrivateServices.Console.Data;
using PrivateServices.Console.Models;
using PrivateServices.Console.Roles;
using PrivateServices.Console.SecurityValidators;
using PrivateServices.Console.Services;
using PrivateServices.Console.Services.Arguments;

Console.WriteLine("Stated");

var host = Host.CreateDefaultBuilder()
    .ConfigureServices(x =>
    {
        x.AddTransient<SecurityValidator<Client>, ClientSecurityValidator>();
        x.AddTransient<IClientsService, ClientsService>();
        x.AddTransient<IClientsModeratorService, ClientsService>();
        x.AddSingleton<ClientsStorage>();
    }).Build();

var scope = host.Services.CreateScope();
var clientsService = scope.ServiceProvider.GetService<IClientsService>();
var editArgument = new EditClientArgument()
{
    EditedName = "edited-name"
};
clientsService.Edit(editArgument);

Console.WriteLine("End");


/*
    companiesService.ExecuteCommand(new GetById(88));
    var company = companiesService.Result.As<Company>();
    -------
    // ошибка доступа: минимальный уровень для изменения - Moderator
    companiesService.ExecuteCommand(new ChangeCompanyInfo(changeModel)); 
    var company = companiesService.Result.As<Company>()
 */
