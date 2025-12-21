
using System;
					
public class Program
{
	public static void Main()
	{
        System.Console.WriteLine("Введите название книги");
		string? name = Console.ReadLine();
        System.Console.WriteLine("Введите автора книги");
		string? author = Console.ReadLine();
        System.Console.WriteLine("Введите год издания");
		string? year = Console.ReadLine();
        System.Console.WriteLine("Введите ISBN");
        string? isbn = Console.ReadLine();
        Int32 yearNum = Convert.ToInt32(year);

		Console.WriteLine($"Автор: {author}, название книги: {name}, год издания: {yearNum}, ISBN: {isbn}");
	}
}