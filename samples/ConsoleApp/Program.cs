// See https://aka.ms/new-console-template for more information

using Nedrech.GorzdravClient;
using Nedrech.GorzdravClient.Entities.Enums;

var api = new GorzdravClient(); // инициализация клиента

var clinics = await api.GetClinicsAsync(); // получение коллекции всех клиник 

var centralClinics = clinics
    .Where(x => x.DistrictName == DistrictName.Адмиралтейский); // LINQ-фильтрация по району

foreach (var clinic in centralClinics)
    Console.WriteLine($"[{clinic.Id}]: {clinic.ShortName}"); // вывод в виде "[1]: clinic short name"