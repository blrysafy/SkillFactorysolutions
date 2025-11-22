using System;
class MainClass {
  public static void Main (string[] args) {
        //DaysOfWeek MyFavoriteDay;

        //MyFavoriteDay = DaysOfWeek.Friday;

        //Console.WriteLine(MyFavoriteDay);


        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        byte age = (byte)int.Parse(Console.ReadLine());
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);
        Console.Write("Enter your birthdate: ");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Your birthdate is {0}", birthdate);
        Console.ReadKey();
    }
}

//enum DaysOfWeek : byte
//{
//    Tuesday,
//    Monday,
//    Wednesday,
//    Friday
//}

