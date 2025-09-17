string country = Console.ReadLine();

string languages = string.Empty;

switch (country)
{
    case "England":
    case "USA":
        languages = "English";
        break;
    case "Spain":
    case "Argentina":
    case "Mexico":
        languages = "Spanish";
        break;
    default:
        languages = "unknown";
        break;
}

Console.WriteLine(languages);