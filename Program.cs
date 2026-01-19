
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

        int option;

        while (true) {
			System.Console.WriteLine("\n1. Добавить книгу");
			System.Console.WriteLine("2. Показать книгу");
			System.Console.WriteLine("0. Выйти\n");
			System.Console.WriteLine("Ваш выбор");


			string? userInput = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(userInput) 
			|| !int.TryParse(userInput, out int userChoice) 
			|| userChoice < 0 
			|| userChoice > 2)
			{
				System.Console.WriteLine("Вы ввели неправильное значение!");
				continue;
			};

			System.Console.WriteLine("Молодец!"); 
			option = userChoice;
			break;
		}

		if (option == 2)
		{
            int signToSearchBy;
            System.Console.WriteLine("Выберите признак, по которому хотите найти книгу");
			while (true) {
				System.Console.WriteLine("\n1. Автор");
				System.Console.WriteLine("2. Название");
				System.Console.WriteLine("3. ISBN");
				System.Console.WriteLine("4. Номер");
				System.Console.WriteLine("0. Выйти\n");
				System.Console.WriteLine("Ваш выбор");


				string? userInput = Console.ReadLine();

				if (string.IsNullOrWhiteSpace(userInput) 
				|| !int.TryParse(userInput, out int userChoice) 
				|| userChoice < 0 
				|| userChoice > 4)
				{
					System.Console.WriteLine("Вы ввели неправильное значение!");
					continue;
				};

				
				signToSearchBy = userChoice;
				break;
			}
			switch (signToSearchBy)
			{
                case 1:
					bool correctAuthor = false;
					while (true) {
						
						Console.WriteLine("Введите автора книги, которую хотите вывести");
						string? authorToSearchBy = Console.ReadLine();
						if (string.IsNullOrEmpty(authorToSearchBy))
						{
							System.Console.WriteLine("Вы ввели неправильное значение!");
							continue;
						}
						for (int i = 0; i < lib.GetLength(0); i++)
						{
							if (authorToSearchBy == lib[i, 0]) {
								System.Console.WriteLine($"Автор - {lib[i, 0]}, название - {lib[i, 1]}, год - {lib[i, 2]}, ISBN - {lib[i, 3]}");
								correctAuthor = true;
							} 
							
						}
						if (!correctAuthor) {
							System.Console.WriteLine("Вы ввели неправильное значение!");
							continue;
						}
						break;
					}
					break;
				case 2:
					bool correctName = false;
                    while (true) {
						Console.WriteLine("Введите название книги, которую хотите вывести");
						string? nameToSearchBy = Console.ReadLine();
						if (string.IsNullOrEmpty(nameToSearchBy))
						{
							System.Console.WriteLine("Вы ввели неправильное значение!");
							continue;
						}
						for (int i = 0; i < lib.GetLength(0); i++)
						{
							if (nameToSearchBy == lib[i, 1]) {
								System.Console.WriteLine($"Автор - {lib[i, 0]}, название - {lib[i, 1]}, год - {lib[i, 2]}, ISBN - {lib[i, 3]}");
								correctName = true;
							}
						}
						if (!correctName) {
							System.Console.WriteLine("Вы ввели неправильное значение!");
							continue;
						}
						break;
					}
					break;
				case 3:
					bool correctISBN = false;
					while (true) {
						
						Console.WriteLine("Введите ISBN книги, которую хотите вывести");
						string? ISBNToSearchBy = Console.ReadLine();
						if (string.IsNullOrEmpty(ISBNToSearchBy))
						{
							System.Console.WriteLine("Вы ввели неправильное значение!");
							continue;
						}
						for (int i = 0; i < lib.GetLength(0); i++)
						{
							if (ISBNToSearchBy == lib[i, 3]) {
								System.Console.WriteLine($"Автор - {lib[i, 0]}, название - {lib[i, 1]}, год - {lib[i, 2]}, ISBN - {lib[i, 3]}");
								correctISBN = true;
							}
						}
						if (!correctISBN) {
							System.Console.WriteLine("Вы ввели неправильное значение!");
							continue;
						}
						break;
					}
					break;
				case 4:
					while (true)
					{
						Console.WriteLine("Введите номер книги, которую хотите вывести");
        
						if (int.TryParse(Console.ReadLine(), out int value))
						{
							if (value < 1 || value > 5)
							{
								System.Console.WriteLine("Вы ввели некорректное число");
								continue;
							} else
							System.Console.WriteLine($"Автор - {lib[value - 1, 0]}, название - {lib[value - 1, 1]}, год - {lib[value - 1, 2]}, ISBN - {lib[value - 1, 3]}");
							break;
						} else
						{
							System.Console.WriteLine("Это не номер");
						}
						;
					}
					break;
				default:

					break;
						
            }
		}

		


		

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