using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PrivateServices.Console.Data;
using PrivateServices.Console.Models;
using PrivateServices.Console.Roles;
using PrivateServices.Console.SecurityValidators;
using PrivateServices.Console.Services;

Console.WriteLine("Stated");

var host = Host.CreateDefaultBuilder()
    .ConfigureServices(x =>
    {
        x.AddTransient<SecurityValidator<Client>, ClientSecurityValidator>();
        x.AddTransient<ClientsServiceBase, ClientsService>();
        x.AddSingleton<ClientsStorage>();
        x.AddSingleton<BlogsStorage>();
    }).Build();

var clientsService = ActivatorUtilities.CreateInstance<ClientsService>(host.Services);
var authorizedClient = clientsService.AuthorizeByName("Sparrow");

authorizedClient.Name = "Sparrow-edit";
var edited = clientsService.Edit(authorizedClient);
Console.WriteLine("Edit user name: " + edited.Name);

Console.WriteLine("End");

authorizedClient.Role = SystemRole.Admin;
edited = clientsService.Edit(authorizedClient); // ошибка доступа: минимальный уровень для изменения - Admin

Console.WriteLine("End");


/*
    companiesService.ExecuteCommand(new GetById(88));
    var company = companiesService.Result.As<Company>();
    -------
    // ошибка доступа: минимальный уровень для изменения - Moderator
    companiesService.ExecuteCommand(new ChangeCompanyInfo(changeModel)); 
    var company = companiesService.Result.As<Company>()
 */
