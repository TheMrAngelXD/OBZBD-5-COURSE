// See https://aka.ms/new-console-template for more information
using DAL;
using PhotoStudio;
using System;

var clients = new Client(213, "Petrov Ivan Albertich", "Moscow RUT MIIT", "miit@miit.ru");
var clients1 = new Client(323, "Petrov Dmitriy Petrovich", "Saint-Petersburg", "1@mail.ru");
var services = new Service("2323", "Photo", "1", "50$");
var orders = new Order("1", clients);
var orders2 = new Order("2", clients1);
orders.AddService(services);
orders2.AddService(services);
Console.WriteLine(orders);
Console.WriteLine(orders2);
var settings = new Settings();

settings.AddDatabaseServer("DESKTOP-PGQ7IF3\\SQLEXPRESS");

settings.AddDatabaseName("PhotoStudio");

using var sessionFactory = Configurator.GetSessionFactory(settings, showSql: true);

using (var session = sessionFactory.OpenSession())
{
    session.Save(clients);
    session.Save(services);
    session.Save(orders);

    session.Flush();
}