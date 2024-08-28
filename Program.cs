 List<Tuple<string, bool>> tasks = new List<Tuple<string, bool>>();
string input;

while (true)
{
Console.WriteLine("Tanlang (raqam bilan):");
Console.WriteLine("1: Vazifa qo'shish");
Console.WriteLine("2: Vazifa o'chirish");
Console.WriteLine("3: Vazifa holatini belgilash");
Console.WriteLine("4: Vazifalar ro'yxatini ko'rsatish");
Console.WriteLine("5: Dasturdan chiqish");
Console.Write("Tanlov: ");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
case 1:
Console.WriteLine("vazifaning nomini kiriting: ");
string yangivazifa = Console.ReadLine();
tasks.Add(new Tuple<string, bool>(yangivazifa, false)); 
Console.WriteLine("vazifa qoshildi: ");
break;

case 2:
Console.WriteLine("vazifa indexini kiriting: ");
for (int i = 0; i < tasks.Count; i++)
{
    Console.WriteLine($"{i + 1}: {tasks[i].Item1} (Bajarilgan: {tasks[i].Item2})");
}
int index = int.Parse(Console.ReadLine())-1;

    if (index >= 0 && index < tasks.Count)
    {
        tasks.RemoveAt(index);
        Console.WriteLine("Vazifa o'chirildi.");
    }
    else
    {
        Console.WriteLine("Noto'g'ri raqam.");
    }
break;

case 3:
Console.WriteLine("vazifa bajarilganligini belgilash uchun uning raqami: ");
for (int i = 0; i < tasks.Count; i++)
{
    Console.WriteLine($"{i + 1}: {tasks[i].Item1} (Bajarilgan: {tasks[i].Item2})");
}
int holati = int.Parse(Console.ReadLine())-1;
if (holati >= 0 && holati < tasks.Count)
    {
        var task = tasks[holati];
        tasks[holati] = new Tuple<string, bool>(task.Item1, !task.Item2);
        Console.WriteLine("Vazifa holati yangilandi.");
    }
    else
    {
        Console.WriteLine("Noto'g'ri raqam.");
    }
break;

case 4:
    Console.WriteLine("Vazifalar ro'yxati:");
    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {tasks[i].Item1} (Bajarilgan: {tasks[i].Item2})");
    }
    break;

case 5:
   Console.WriteLine("Dasturdan chiqyapti...");
   return;

default:
   Console.WriteLine("Noto'g'ri tanlov.");
   break;
}
}