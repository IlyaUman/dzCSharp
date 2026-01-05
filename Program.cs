
using System;
using System.Globalization;

public class Program
{
	public static void Main()
	{
		string?[,] lib = new string?[5,4];

		System.Console.WriteLine("Введите автора первой книги");
		lib[0, 0] = Console.ReadLine();
		System.Console.WriteLine("Введите название первой книги");
		lib[0, 1] = Console.ReadLine();
		System.Console.WriteLine("Введите год издания");
		lib[0, 2] = Console.ReadLine();
		System.Console.WriteLine("Введите ISBN");
		lib[0, 3] = Console.ReadLine();
		
		System.Console.WriteLine("Введите автора второй книги");
		lib[1, 0] = Console.ReadLine();
		System.Console.WriteLine("Введите название второй книги");
		lib[1, 1] = Console.ReadLine();
		System.Console.WriteLine("Введите год издания");
		lib[1, 2] = Console.ReadLine();
		System.Console.WriteLine("Введите ISBN");
		lib[1, 3] = Console.ReadLine();
		
		System.Console.WriteLine("Введите автора третьей книги");
		lib[2, 0] = Console.ReadLine();
		System.Console.WriteLine("Введите название третьей книги");
		lib[2, 1] = Console.ReadLine();
		System.Console.WriteLine("Введите год издания");
		lib[2, 2] = Console.ReadLine();
		System.Console.WriteLine("Введите ISBN");
		lib[2, 3] = Console.ReadLine();

		System.Console.WriteLine("Введите автора четвёртой книги");
		lib[3, 0] = Console.ReadLine();
		System.Console.WriteLine("Введите название четвёртой книги");
		lib[3, 1] = Console.ReadLine();
		System.Console.WriteLine("Введите год издания");
		lib[3, 2] = Console.ReadLine();
		System.Console.WriteLine("Введите ISBN");
		lib[3, 3] = Console.ReadLine();

		System.Console.WriteLine("Введите автора пятой книги");
		lib[4, 0] = Console.ReadLine();
		System.Console.WriteLine("Введите название пятой книги");
		lib[4, 1] = Console.ReadLine();
		System.Console.WriteLine("Введите год издания");
		lib[4, 2] = Console.ReadLine();
		System.Console.WriteLine("Введите ISBN");
		lib[4, 3] = Console.ReadLine();


		while (true) {
			System.Console.WriteLine("\n1. Добавить книгу");
			System.Console.WriteLine("2. Показать книгу");
			System.Console.WriteLine("0. Выйти\n");
			System.Console.WriteLine("Ваш выбор");


			string userInput = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(userInput) 
			|| !int.TryParse(userInput, out int userChoice) 
			|| userChoice < 0 
			|| userChoice > 2)
			{
				System.Console.WriteLine("Вы ввели неправильное значение!");
				continue;
			};

			System.Console.WriteLine("Молодец!"); 
			break;
		}

		Console.WriteLine("Введите номер книги, которую хотите вывести");
        
		if (int.TryParse(Console.ReadLine(), out int value))
		{
			if (value < 1 || value > 5)
			{
				System.Console.WriteLine("Вы ввели некорректное число");
			} else
			System.Console.WriteLine($"Автор - {lib[value - 1, 0]}, название - {lib[value - 1, 1]}, год - {lib[value - 1, 2]}, ISBN - {lib[value - 1, 3]}");
		} else
		{
			System.Console.WriteLine("Такой книги нет");
		}
		;
		System.Console.WriteLine("А теперь выведем остальные книги");
		for (int i = 0; i < 5; i ++)
		{
			if (i != value)
			{
				System.Console.WriteLine($"Автор - {lib[i, 0]}, название - {lib[i, 1]}, год - {lib[i, 2]}, ISBN - {lib[i, 3]}");
			};
		};

		

// System.Console.WriteLine("Введите ISBN книги, которую хотите найти");
        // System.Console.WriteLine("Что Вы хотите сделать?");
		// string? action = Console.ReadLine();
		// switch (action)
		// {
		// 	case "Добавить книгу":
		// 		System.Console.WriteLine("Добавить книгу");
		// 		break;
		// 	case "Показать книгу":
		// 		System.Console.WriteLine("Показать книгу");
		// 		break;
		// 	case "Выйти":
		// 		System.Console.WriteLine("Выйти");
		// 		break;
		// 	default:
		// 		System.Console.WriteLine("Вы ввели что-то не то");
		// 		break;
		// }
	}
}