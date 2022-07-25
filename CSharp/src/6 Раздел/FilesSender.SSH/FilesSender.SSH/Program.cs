using Renci.SshNet;
using System.Configuration;

var host = ConfigurationManager.AppSettings.Get("host");
var username = ConfigurationManager.AppSettings.Get("username");
var password = ConfigurationManager.AppSettings.Get("password");
var filePath = ConfigurationManager.AppSettings.Get("filePath")!;
var fileName = Path.GetFileName(filePath);
var destinationPath = ConfigurationManager.AppSettings.Get("destination") + "/" + fileName;

using (var client = new ScpClient(host, username, password))
{
    client.Connect();

    using (var fileStream = new FileStream(filePath, FileMode.Open))
    {
        client.Upload(fileStream, destinationPath);
    }

    client.Disconnect();
}