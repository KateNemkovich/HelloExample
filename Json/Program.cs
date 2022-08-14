using Json.Objects;
using Json.Objects.Enums;
using Newtonsoft.Json;
using System.Text.Json;
using Newtonsoft.Json.Converters;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

Console.WriteLine("Hello, Roma");
Console.WriteLine("Hello, Kate");
var ourHistory = new OurHistory
{
    Title = "Years",
    Stories = new List<YearStory>
    {
        new()
        {
            Year = 2013,
            X = true,
            Y = 0.5,
            Q="Some text",
            HappinessLevel= HappinessLevel.Happy
        },
        new()
        {
            Year = 2014,
            X = false,
            Y = 0.6,
            HappinessLevel= HappinessLevel.Unknown
        },
        new()
        {
            Year = 2015,
            X = true,
            Y = 0.7,
            HappinessLevel= HappinessLevel.Happy
        },
        new()
        {
            Year = 2016,
            X = true,
            Y = 0.8,
            Q="Some text",
            HappinessLevel= HappinessLevel.Unknown
        },
        new()
        {
            Year = 2017,
            X = false,
            Y = 0.9,
            Q="Some text",
            HappinessLevel= HappinessLevel.Happy
        },
        new()
        {
            Year = 2018,
            X = true,
            Y = 0.5,
            Q="Some text",
            HappinessLevel= HappinessLevel.Unknown
        },
        new()
        {
            Year = 2019,
            X = false,
            Y = 0.9,
            Q="Some text",
            HappinessLevel= HappinessLevel.Happy
           
        },
        new()
        {
            Year = 2020,
            X = true,
            Y = 0.5,
            Q="Some text",
            HappinessLevel= HappinessLevel.Unknown
        },
        new()
        {
            Year = 2021,
            X = true,
            Y = 0.5,
            Q="Some text",
            HappinessLevel= HappinessLevel.Unknown
        },
        new()
        {
            Year = 2022,
            X = false,
            Y = double.PositiveInfinity,
            Q="Some text",
            HappinessLevel= HappinessLevel.Happy
        },
        new()
        {
            Year = 2023,
            X = true,
            Y = double.NaN,
            Q= "future",
            HappinessLevel= HappinessLevel.Unknown,
            SomeList = new List<int>(){1,2,3,4,5,6,7,8,9}
        }
    }
    
};

/*JsonSerializerOptions option = new JsonSerializerOptions()
 {
     WriteIndented = true
 };

JsonSerializerOptions options = new JsonSerializerOptions()
 {
     IgnoreNullValues = false
};
Методы другой библиотеки, не подходят
*/
//var json =  JsonSerializer.Serialize(ourHistory, options);
//var json = JsonSerializer.Serialize(ourHistory, typeof(OurHistory));
var jsonSerializerSettings = new JsonSerializerSettings
{
    Converters = new List<JsonConverter>
    {
        new StringEnumConverter()
    },
    NullValueHandling = NullValueHandling.Ignore
};

var json = JsonConvert.SerializeObject(ourHistory,Formatting.Indented,jsonSerializerSettings);


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

var restoredHistory = JsonConvert.DeserializeObject<OurHistory>(json);
// var restoredHistory = JsonConvert.DeserializeObject<OurHistory>(File.ReadAllText( "Story.json"));
// OurHistory restoredHistory=JsonConvert.DeserializeObject<OurHistory>(json);
Console.WriteLine(json);