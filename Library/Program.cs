// See https://aka.ms/new-console-template for more information
using System;
using PhotoStudio;
var clients = new Clients("1", "Petrov Ivan Albertich", "Moscow RUT MIIT", "miit@miit.ru");
var services = new Services("1", "Photo", "1", "50$");
var orders = new Order("1", clients);
Console.WriteLine(orders);