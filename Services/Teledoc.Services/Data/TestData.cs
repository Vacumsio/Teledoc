using System.Collections.Generic;
using Teledoc.Domain.Entities.Clients;
using Teledoc.Domain.Entities.Founders;

namespace Teledoc.Services.Data
{
    public static class TestData
    {
        public static IEnumerable<Client> Clients { get; } = new[]
        {
            new Client{Id=1,Organization="ОАО",Name="Рога и Копыта",ClientsINN=430144940226,FounderId=4},
            new Client{Id=2,Organization="ООО",Name="Ананас",ClientsINN=301282992942,FounderId=5},
            new Client{Id=3,Organization="ЗАО",Name="Измаил",ClientsINN=263480325470,FounderId=6},
            new Client{Id=4,Organization="ПАО",Name="Кокоро",ClientsINN=397364261307,FounderId=3},
            new Client{Id=5,Organization="ИП",Name="Артас Пендрагон",ClientsINN=516962457342,FounderId=8},
            new Client{Id=6,Organization="ОАО",Name="Цепеш и Ко",ClientsINN=773158126820,FounderId=1},
            new Client{Id=7,Organization="ООО",Name="Рога и Копыта",ClientsINN=441275906211,FounderId=7},
            new Client{Id=8,Organization="ООО",Name="Рога и Копыта",ClientsINN=978830626815,FounderId=1},
            new Client{Id=9,Organization="ИП",Name="Влад Цепеш",ClientsINN=459517949750,FounderId=2},
            new Client{Id=10,Organization="ИП",Name="Айзек Азимов",ClientsINN=871494862478,FounderId=3},
        };

        public static IEnumerable<Founder> Founders { get; } = new[]
        {
            new Founder{Id=1,Firstname="Иван",Surname="Иванов",Patronymic="Иванович"},
            new Founder{Id=2,Firstname="Сидор",Surname="Сидоров",Patronymic="Сидорович"},
            new Founder{Id=3,Firstname="Петр",Surname="Петров",Patronymic="Петрович"},
            new Founder{Id=4,Firstname="Евгений",Surname="Силушкин",Patronymic="Луянович"},
            new Founder{Id=5,Firstname="Ефросиния",Surname="Фролова",Patronymic="Фросечкина"},
            new Founder{Id=6,Firstname="Клавдия",Surname="Прок",Patronymic="Семеновна"},
            new Founder{Id=7,Firstname="Карл",Surname="Фридрих",Patronymic="Энтшмидт"},
            new Founder{Id=8,Firstname="Элтон",Surname="Власов",Patronymic="Евгеньевич"}
        };
    }
}
