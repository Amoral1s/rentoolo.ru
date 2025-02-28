﻿namespace Rentoolo.Model
{
    public enum CategoriesEnum
    {
        //Все объявления в России 52 375 593  Статистика Авито от 28.04.19, 01.05.19

        Transport = 10,//Транспорт 11 096 058 

        Auto = 101,//Автомобили 691 863

        Moto = 102,//Мотоциклы и мототехника 90 360

        Motorcycles = 1021,//Мотоциклы 43 879

        RoadMotorcycles = 10211,//Дорожные 21 595

        CrossMotorcyclesEnduro = 10212,//Кросс и эндуро 9 449

        SportBike = 10214,//Спортивные 7 837

        Chopper = 10215,//Чопперы 4 147

        CustomBikes = 10217,//Кастом-байки 850

        Scooters = 1022,//Мопеды и скутеры 23 594

        Atv = 1023,//Квадроциклы 10 219

        CrossCountryVehicle = 1023,//Вездеходы 2 686

        Buggy = 1024,//Багги 1 037

        Carting = 1025,//Картинг 489

        Truck = 104,//Грузовики и спецтехника 174 461

        AutoTruck = 10401,//Грузовики 52 808

        FarmingTruck = 10402,//Сельхозтехника 45 198

        Trailer = 10403,//Прицепы 24 661

        PrimeMover = 10404,//Тягачи 11 327

        Loader = 10405,//Погрузчики 8 766

        LightCommercialVehicles = 10406,//Лёгкий транспорт 7 165

        ConstructionTruck = 10407,//Строительная техника 4 773

        Bus = 10408,//Автобусы 4 453

        CommunalTruck = 10409,//Коммунальная техника 3 638

        Excavators = 10410,//Экскаваторы 3 445

        TruckCranes = 10411,//Автокраны 2 810

        Camper = 10412,//Автодома 2 483

        LoggingTruck = 10414,//Техника для лесозаготовки 1 563

        Bulldozer = 10415,//Бульдозеры 1 204

        WaterTransport = 105,//Водный транспорт 58 276

        SpareParts = 106,//Запчасти и аксессуары 10 083 451

        Realty = 20,//Недвижимость 2 681 204

        Apartment = 201,//Квартиры 1 221 760

        Room = 202,//Комнаты 108 657

        House = 203,//Дома, дачи, коттеджи 602 831

        Land = 204,//Земельные участки 399 530

        Garage = 205,//Гаражи и машиноместа 147 937

        CommercialRealEstate = 206,//Коммерческая недвижимость 197 781

        RealEstateAbroad = 207,//Недвижимость за рубежом 2 518

        Job = 30,//Работа 2 041 161

        Resume = 301,//Резюме 1 790 209

        Vacancy = 302,//Вакансии 250 984

        Services = 40,//Услуги 1 462 151

        ItInternetTelecom = 401,//IT, интернет, телеком 32 616

        WebsiteDevelopmentMarketing = 4011,//Cоздание и продвижение сайтов 10 008

        WebsiteDevelopment = 40111,

        WebsiteMarketing = 40112,

        SoftwareInstallationSetup = 4012,//Установка и настройка ПО 7 924

        SettingupInternetNetworks = 4013,//Настройка интернета и сетей 3 422

        ItMaster = 4014,//Мастер на все случаи 11 261

        PersonalGoods = 50,//Личные вещи 21 024 183

        ClothesShoesAccessories = 501,//Одежда, обувь, аксессуары 9 833 238

        WomensClothing = 5011,//Женская одежда 7 436 340 Статистика Авито 280419

        WomensClothingFootwear = 501101,//Обувь 2 064 452

        WomensClothingDressesSkirts = 501102,//Платья и юбки 1 650 679

        WomensClothingOuterwear = 501103,//Верхняя одежда 1 617 139

        WomensClothingShirtsBlouses = 501104,//Рубашки и блузки 291 000

        WomensClothingKnitwear = 501105,//Трикотаж 290 682

        WomensClothingJacketsSuits = 501106,//Пиджаки и костюмы 236 122

        WomensClothingJeans = 501107,//Джинсы 214 754

        WomensClothingWeddingDresses = 501108,//Свадебные платья 213 575

        WomensClothingPants = 501109,//Брюки 209 829

        WomensClothingTopsTshirts = 501110,//Топы и футболки 144 730

        WomensClothingUnderwear = 501111,//Нижнее бельё 109 946

        WomensClothingSwimwear = 501112,//Купальники 63 570

        WomensClothingOther = 501114,//Другое 328 523

        MensClothing = 5012,//Мужская одежда 1 373 191

        MensClothingFootwear = 501201,//Обувь 374 732

        MensClothingOuterwear = 501202,//Верхняя одежда 372 270

        MensClothingKnitwearTshirts = 501203,//Трикотаж и футболки 148 550

        MensClothingJacketsSuits = 501204,//Пиджаки и костюмы 141 591

        MensClothingShirtsBlouses = 501205,//Рубашки 77 719

        MensClothingJeans = 501206,//Джинсы 69 637

        MensClothingPants = 501207,//Брюки 59 756

        MensClothingOther = 501208,//Другое 124 212

        ClothingAccessories = 5014,//Аксессуары 1 022 978

        ChildrensClothing = 502,//Детская одежда и обувь 7 114 528

        GirlsClothing = 5021,//Для девочек 4 099 055

        GirlsClothingFootwear = 502101,//Обувь 1 078 248

        GirlsClothingOuterwear = 502102,//Верхняя одежда 957 440

        GirlsClothingDressesSkirts = 502103,//Платья и юбки 747 390

        GirlsClothingKnitwear = 502104,//Трикотаж 308 836

        GirlsClothingOverallsBody = 502105,//Комбинезоны и боди 300 489

        GirlsClothingPants = 502106,//Брюки 200 630

        GirlsClothingHatsMittensScarves = 502107,//Шапки, варежки, шарфы 149 334

        GirlsClothingSleepwear = 502108,//Пижамы 12 813

        GirlsClothingOther = 502109,//Другое 328 523

        BoysClothing = 5022,//Для мальчиков 2 982 264

        BoysClothingFootwear = 502201,//Обувь 935 457

        BoysClothingOuterwear = 502202,//Верхняя одежда 764 609

        BoysClothingKnitwear = 502203,//Трикотаж 314 485

        BoysClothingPants = 502204,//Брюки 252 924

        BoysClothingOverallsBody = 502205,//Комбинезоны и боди 242 604

        BoysClothingHatsMittensScarves = 502206,//Шапки, варежки, шарфы 107 576

        BoysClothingSleepwear = 502207,//Пижамы 12 401

        BoysClothingOther = 502208,//Другое 352 200

        GoodsForChildrenToys = 503,

        WatchesJewelery = 504,

        HealthBeauty = 505,

        HomeGarden = 60,

        Appliances = 601,

        FurnitureInterior = 602,

        DishesKitchenware = 603,

        Food = 604,

        RepairConstruction = 605,

        Plants = 607,

        ConsumerElectronics = 70,

        AudioVideo = 701,

        GamesConsolesPrograms = 702,

        DesktopComputers = 703,

        Laptops = 704,

        OfficeEquipmentConsumables = 705,

        TabletsEbooks = 706,

        Phones = 707,

        ComputerProducts = 708,

        PhotographicEquipment = 709,

        HobbyRest = 80,

        TicketsTravel = 801,

        Bicycles = 802,

        BooksMagazines = 803,

        Collecting = 804,

        MusicalInstruments = 805,

        HuntingFishing = 806,

        SportsRest = 807,

        Pets = 90,

        Dogs = 901,

        Cats = 902,

        Birds = 903,

        Aquarium = 904,

        OtherAnimals = 905,

        GoodsPets = 906,

        Business = 1000,

        ReadyBusiness = 1001,

        FurnitureBusiness = 1002
    }
}