﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Как Вас зовут?");
        int q = 22;
        string keep = Console.ReadLine();
        keep = keep + "\nА меня зовут - " + AppDomain.CurrentDomain.FriendlyName + "\nПриятно было с Вами познакомиться!";
        Console.WriteLine("Здравствуйте, {0}", keep);
        Console.WriteLine("А сколько Вам лет?");
        keep = Console.ReadLine();
        string progAnswear = ",а выглядите всего на 20 \nа мне вот всего лишь 1 день от роду!:D";
        Console.WriteLine($"Ого уже, {keep}{progAnswear}");
    }
}