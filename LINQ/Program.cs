using System.Linq;

List<string> names = new List<string>
{
    "mark",
    "stone",
    "Nina",
    "Lars",
    "Kasper",
    "Lars",
    "Lene",
    "Kathrine"
};

//EXTENSION METHODS

var marksName = names.First();

//Console.WriteLine(marksName);

var kat = names.Last();

//Console.WriteLine(kat);

//only works with 1 elemnt
//var test = names.Single();
//Console.WriteLine(test);

var sten = names.First(name => name.Length > 4);

//Console.WriteLine(sten);

var lene = names.Last(name => name.Length < 5);

//Console.WriteLine(lene);

var single = names.Single(name => name.Length == 5);

//Console.WriteLine(single);

var firstOrDefault = names.FirstOrDefault("Peter");

//Console.WriteLine(firstOrDefault);

var noNames = new List<string>();
var defaultName = noNames.FirstOrDefault("Peter");

//Console.WriteLine(defaultName);

var moreNames = names.Take(2);

foreach (string name in moreNames)
    //print(moreNames);

    moreNames = names.Skip(2);

//print(moreNames);


//Takes untill something does not satisfy condtion
moreNames = names.TakeWhile(name => name.Length <= 5);

//print(moreNames);

//Skips untill something satisfies condition
moreNames = names.SkipWhile(name => name.Length <= 5);

//print(moreNames);

moreNames = names.TakeLast(3);

//print(moreNames);

moreNames = names.SkipLast(3);

//print(moreNames);

moreNames = names.Where(name => name.Substring(0, 1) == "K");

//print(moreNames);


moreNames = names.Distinct();

//print(moreNames);

List<string> otherNames = new List<string> { "mark", "stone", "Ole", "Fin" };

var intersect = names.Intersect(otherNames);

//print(intersect);

var union = names.Union(otherNames);

//print(union);


otherNames.Reverse();

//print(otherNames);

var reversedAgain = otherNames.OrderByDescending(name => name);

//print(reversedAgain);

var sort = otherNames.OrderBy(name => name);

//print(sort);

var orderbyLength = otherNames.OrderBy(name => name.Length);

//print(orderbyLength);

var multi = otherNames.OrderBy(name => name.Length).ThenBy(name => name).ToList();

//print(multi);

var count = otherNames.Count();
//Console.WriteLine(count);

count  = otherNames.Count(name => name.Length <= 3);
//Console.WriteLine(count);


var map = otherNames.Select(name => name.ToUpper());
//print(map);


//QUERY SYNTAX

IEnumerable<string> longNames =
    from name in names
    where name.Length >= 5
    orderby name.Length
    select name;

foreach (string name in longNames)
{
    // Console.WriteLine(name);
}


//extension method
string s = "";
bool test = s.IsNullOrEmpty();
Console.WriteLine(test);




void print(IEnumerable<string> names)
{
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}

public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }
}