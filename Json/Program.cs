using Json.Objects;

Console.WriteLine("Hello, Roma");
Console.WriteLine("Hello, Kate");

var ourHistory = new OurHistory
{
    Stories = new List<YearStory>
    {
        new()
        {
            Year = 2013
        },
        new()
        {
            Year = 2014
        },
        new()
        {
            Year = 2015
        },
        new()
        {
            Year = 2016
        },
        new()
        {
            Year = 2017
        },
        new()
        {
            Year = 2018
        },
        new()
        {
            Year = 2019
        },
        new()
        {
            Year = 2020
        },
        new()
        {
            Year = 2021
        },
        new()
        {
            Year = 2022
        },
        new()
        {
            Year = 2023
        }
    }
};

//TODO Подключить Nuget пакет Newtonsoft.Json
//TODO Добавить в класс YearStory поля на все стандартные типы данных, bool, double, string, Enum HappinessLevel
//TODO Заполнить данными в этом классе с 6й строки
//TODO добавить одно поле double и заполнить значением double.NaN, double.PositiveInfinity
//TODO добавить одно поле string и оставить незаполненным или явно заполнить null
//TODO добавить одно поле List<>, заполнить значениями
//TODO включить опцию переноса новых запписей в Json на новую строку
//TODO отключить опцию добавления полей с null в Json
//TODO Сериализовать нашу историю в Json
//TODO Десериализовать нашу историю в переменную

//Идея в том чтобы ты видела как сереализуются 
//Метод для сериализации JsonConvert.SerializeObject, поэсперементируй с JsonSerializerSettings, который передается в конструктор
//TODO сереализовать Json здесь

var jsonPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Story.json");

//Созраняет Json на рабочий стол, открой через блокнот, изучи структуру, как выглядят списки, как значения
File.WriteAllText(jsonPath, json);

//Считывает Json с файла
var text = File.ReadAllText(jsonPath);
//TODO десереализовать Json здесь