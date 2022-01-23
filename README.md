# Gorzdrav SPb API Unofficial Client for .NET
Неофициальная библиотека для взаимодействия с API сервиса.
## Установка
NuGet (скоро)
## Использование
```c#
using Nedrech.GorzdravClient;
using Nedrech.GorzdravClient.Entities.Enums;

var api = new GorzdravClient(); // инициализация клиента

var clinics = await api.GetClinicsAsync(); // получение коллекции всех клиник 

var centralClinics = clinics
    .Where(x => x.DistrictName == DistrictName.Адмиралтейский); // фильтрация
                                                                // по району
    
foreach(var clinic in centralClinics)
    Console.WriteLine($"[{clinic.Id}]: {clinic.ShortName}"); // вывод в виде:
                                                             // "[1]: clinic short name"
```

## Поддерживаемые платформы

Пока что только <b>.NET 6</b>.

## Дорожная карта

Библиотека будет включать/включает в себя методы для следующих операций:

- [x] Получение списка районов
- [x] Получение списка клиник
- [x] Получение списка специальностей клиники
- [x] Получение списка докторов по специальности
- [x] Получение списка номерков на прием к доктору
- [ ] Получение списка записей на прием
- [ ] Запись на прием
- [ ] Отмена записи на прием
## Помощь проекту
- Issues - предложения по добавлению нового функционала
- Pull requests