using Newtonsoft.Json;

namespace CSProjeDemo_2
{
    public class ReadFolder
    {
        private string path = "~/CSProjeDemo-2/ConsoleApp/personnel.json";
        public static List<Personnel> EmployeeListRead(string path)
        {
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Personnel>>(json);
        }
    }
}
