// C#7.0以前的作法

DateTime time;
int temperature;

GetLocalStatus("台灣", out time, out temperature);

Console.WriteLine($"台灣的時間: {time} ，溫度: {temperature}");

static void GetLocalStatus(string country, out DateTime time, out int temperature)
{
    time = DateTime.UtcNow.AddHours(8);
    temperature = 25;
}

// 範例 John Cena function

var (name_0, birthday_0, country_0, age_0) = JohnCena("zh");
Console.WriteLine($"名字: {name_0} ，生日: {birthday_0}， 國籍: {country_0}， 年齡: {age_0}");

string name_1;
string birthday_1;
string country_1;
int age_1;
(name_1, birthday_1, country_1, age_1) = JohnCena("en");
Console.WriteLine($"名字: {name_1} ，生日: {birthday_1}， 國籍: {country_1}， 年齡: {age_1}");

string name_2;
string country_2;
(name_2, string birthday_2, country_2, int age_2) = JohnCena("jp");
Console.WriteLine($"名字: {name_1} ，生日: {birthday_1}， 國籍: {country_1}， 年齡: {age_1}");

static (string, string, string, int) JohnCena(string lang)
{
    switch (lang.ToLower())
    {
        case "zh":
            return ("約翰·希南", "1977年4月23日", "英國人", 45);
        case "en":
            return ("John Cena", "4/23/1977", "British", 45);
    }
    return ("unknown", "1977-04-23", "unknown", 45);
}

// 06/09/2022 新增範例，將function當物件使用
var (_, birthday_3, _, age_3) = JohnCena("to");

static (string name, string birthday, string country, int year) JohnCena0609(string lang)
{
    switch (lang.ToLower())
    {
        case "zh":
            return ("約翰·希南", "1977年4月23日", "英國人", 45);
        case "en":
            return ("John Cena", "4/23/1977", "British", 45);
    }
    return ("unknown", "1977-04-23", "unknown", 45);
}

var x = JohnCena0609("zh");
Console.WriteLine($"名字: {x.name} ，生日: {x.birthday}， 國籍: {x.country}， 年齡: {x.year}");

// 解構式範例

var JohnCenaModel = new Person("John Cena", new DateTime(1977, 4, 23), "British", 45);

var (name, age) = JohnCenaModel;
Console.WriteLine($"解構式 名字: {name}， 年齡: {age}");

public class Person
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public string Country { get; set; }
    public int Age { get; set; }
    public Person(string name, DateTime birthday, string country, int age)
    {
        Name = name;
        Birthday = birthday;
        Country = country;
        Age = age;
    }

    public void Deconstruct(out string name, out int age)
    {
        name = Name;
        age = Age;
    }

    public void Deconstruct(out string name, out DateTime birthday, out string country)
    {
        name = Name;
        birthday = Birthday;
        country = Country;
    }
}

