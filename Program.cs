
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

		System.Console.WriteLine("Что Вы хотите сделать?");
		string? action = Console.ReadLine();
		switch (action)
		{
			case "Добавить книгу":
				System.Console.WriteLine("Добавить книгу");
				break;
			case "Показать книгу":
				System.Console.WriteLine("Показать книгу");
				break;
			case "Выйти":
				System.Console.WriteLine("Выйти");
				break;
			default:
				System.Console.WriteLine("Вы ввели что-то не то");
				break;
		}
	}
}