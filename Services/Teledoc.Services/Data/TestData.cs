using System.Collections.Generic;
using Teledoc.Domain.Entities.Clients;
using Teledoc.Domain.Entities.Founders;

namespace Teledoc.Services.Data
{
    public static class TestData
    {
        public static IEnumerable<Client> Clients { get; } = new[]
        {
            new Client{Organization="ОАО",Name="Рога и Копыта",ClientsINN=430144940226,FounderId = 4},
            new Client{Organization="ООО",Name="Ананас",ClientsINN=301282992942,FounderId = 2},
            new Client{Organization="ЗАО",Name="Измаил",ClientsINN=263480325470,FounderId = 3},
            new Client{Organization="ПАО",Name="Кокоро",ClientsINN=397364261307,FounderId = 1},
            new Client{Organization="ОАО",Name="Цепеш и Ко",ClientsINN=773158126820,FounderId = 6},
            new Client{Organization="ООО",Name="Рога и Копыта",ClientsINN=441275906211,FounderId = 1},
            new Client{Organization="ООО",Name="Рога и Копыта",ClientsINN=978830626815,FounderId = 6},
            new Client{Organization="ИП",Name="Артас Пендрагон",ClientsINN=516962457342,FounderId = 3},
            new Client{Organization="ИП",Name="Влад Цепеш",ClientsINN=459517949750,FounderId = 4},
            new Client{Organization="ИП",Name="Айзек Азимов",ClientsINN=871494862478,FounderId = 5},
        };

        public static IEnumerable<Founder> Founders { get; } = new[]
        {
            new Founder{Firstname="Иван",Surname="Иванов",Patronymic="Иванович"},
            new Founder{Firstname="Сидор",Surname="Сидоров",Patronymic="Сидорович"},
            new Founder{Firstname="Петр",Surname="Петров",Patronymic="Петрович"},
            new Founder{Firstname="Евгений",Surname="Силушкин",Patronymic="Луянович"},
            new Founder{Firstname="Ефросиния",Surname="Фролова",Patronymic="Фросечкина"},
            new Founder{Firstname="Клавдия",Surname="Прок",Patronymic="Семеновна"},
            new Founder{Firstname="Карл",Surname="Фридрих",Patronymic="Энтшмидт"},
            new Founder{Firstname="Элтон",Surname="Власов",Patronymic="Евгеньевич"}
        };
    }
}
