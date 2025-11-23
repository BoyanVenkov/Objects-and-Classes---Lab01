List<string> inputList = Console.ReadLine().Split().ToList();

Random rnd = new Random();

while (inputList.Count > 0)
{
    int num = rnd.Next(0, inputList.Count);
    Console.WriteLine(inputList[num]);
    inputList.RemoveAt(num);
}