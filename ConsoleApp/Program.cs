using CSProjeDemo_2;
using Newtonsoft.Json;

static void Main(string[] args)
{
    Console.WriteLine("Enter JSON file path:");
    string jsonFilePath = Console.ReadLine();

    string json = File.ReadAllText(jsonFilePath);
    List<Personnel> personnelList = JsonConvert.DeserializeObject<List<Personnel>>(json);

    List<string> reports = new List<string>();

    foreach (var personnel in personnelList)
    {
        Console.WriteLine($"Enter working hour for {personnel.FullName}:");
        personnel.WorkingHour = Convert.ToInt32(Console.ReadLine());

        double salary = personnel.CalculateSalary();

        if (personnel.WorkingHour < 150)
        {
            reports.Add($"{personnel.FullName} worked less than 150 hours.");
        }

        string report = JsonConvert.SerializeObject(new
        {
            Name = personnel.FullName,
            WorkingHour = personnel.WorkingHour,
            Salary = salary
        }, Formatting.Indented);

        reports.Add(report);
    }

    Console.WriteLine("\nSalary Report:");
    foreach (var report in reports)
    {
        Console.WriteLine(report);
    }

    Console.ReadLine();
}