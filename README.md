# Gorzdrav SPb API Unofficial Client for .NET
Неофициальная библиотека для взаимодействия с API сервиса.
## Установка
NuGet (скоро)
## Использование
```c#
using Nedrech.GorzdravClient;
using Nedrech.GorzdravClient.Models.Enums;

var api = new GorzdravClient(); // инициализация клиента

var clinics = await api.GetClinicsAsync(); // получение коллекции всех клиник 

var centralClinics = clinics
    .Where(x => x.DistrictName == DistrictName.Адмиралтейский); // фильтрация
                                                                // по району
    
foreach(var clinic in centralClinics)
    Console.WriteLine($"[{clinic.Id}]: {clinic.ShortName}"); // вывод в виде:
                                                             // "[1]: clinic short name"
```
## Уже реализовано или будет реализовано
Библиотека будет включать/включает в себя методы для следующих операций:
- [x] Получение списка районов
- [x] Получение списка клиник
- [x] Получение списка специальностей клиники
- [ ] Получение списка докторов по специальности
- [ ] Получение расписания докторов
- [ ] Запись на прием
- [ ] Отмена записи на прием
- [ ] Получение списка записей на прием
## Помощь проекту
- Issues - предложения по добавлению нового функционала
- Pull requests