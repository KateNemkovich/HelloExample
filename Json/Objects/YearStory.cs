using Json.Objects.Enums;
using Newtonsoft.Json;

namespace Json.Objects;

public class YearStory
{
    public int Year { get; set; }
    public bool X { get; set; }
    public double Y { get; set; }
    
    [JsonIgnore]
    public string Q { get; set; }
    public HappinessLevel HappinessLevel {get;set;}

    public List<int> SomeList { get; set; }


}