using System;


namespace module4solutions;

internal class NameByLetter
{
    public static void ReverseName()
    {

        Console.Write("Enter your name:");
        var user_name = Console.ReadLine();

        for (int i = user_name.Length - 1; i >= 0; i--)
        {
            Console.Write($"{user_name[i]}"  + " ");

        }



    }

}



