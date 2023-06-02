

using ExampleWork;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

string path = "E:\\Задание\\Задание\\data.json"; 
List<Worker> workers = new List<Worker>();
workers = JsonConvert.DeserializeObject<List<Worker>>(File.ReadAllText(path));
workers = workers.OrderByDescending(worker => worker.salary).ToList();
foreach (Worker worker in workers)
{
    worker.phoneNumber = worker.phoneNumber.Insert(0, "+").Insert(2,"(").Insert(6, ")").Insert(10,"-").Insert(13,"-");
}
using (StreamWriter sw = new StreamWriter("output.txt", false, System.Text.Encoding.UTF8))
{
    for (int i = 0; i < 20; i++)
    {
        sw.WriteLine($"{workers[i].name} {workers[i].phoneNumber} {workers[i].salary}");
    }
}
