namespace LinqExample
{
	internal class Program
	{
		/// <summary>
		///מסנן רשימה של מספרים שלמים כדי להחזיר רשימה חדשה המכילה את ריבועי המספרים הזוגיים.
		/// </summary>
		/// <param name="numbers"></param>
		/// <returns></returns>
		public static List<int> FilterAndSquareEvenNumbers(List<int> numbers)
		{
			// יוצרת רשימה חדשה שתכיל את ריבועי המספרים הזוגיים
			List<int> squaredEvens = new List<int>();
			// עובר על כל המספרים ברשימה המקורית
			foreach (var number in numbers)
			{
				// בודק אם המספר זוגי
				if (number % 2 == 0)
				{
					squaredEvens.Add(number * number);
				}

			}
			// מחזיר את הרשימה החדשה עם ריבועי המספרים הזוגיים
			return squaredEvens;
		}

		/// <summary>
		/// מחזיר רשימה של מחרוזות ובודק אם יש בהן מחרוזת שמתחילה באות מסוימת.
		/// </summary>
		/// <param name="strings"></param>
		/// <param name="ch"></param>
		/// <returns></returns>
		public static bool AnyStartsWithALetter(List<string> strings,char ch)
		{
			foreach (var str in strings)
			{
				//בודק אם התו הראשון של המחרוזת הוא התו שניתן
				if (str[0]==ch)
				{
					return true;
				}
			}
			// אם לא נמצאה מחרוזת שמתחילה באות שניתנה, מחזיר false
			return false;
		}
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			
			//using regular method to filter even numbers and square them
			List<int> squaredEvens = FilterAndSquareEvenNumbers(numbers);

			String str="";
			str.MessageToIsrael();
			//using Extension methods to filter even numbers and square them
			List<int> squaredEvensExt = numbers.FilterAndSquareEvenNumbers();

			// Using LINQ to filter even numbers and square them
			List<int> squaredEvensLinq = numbers.Where(n => n % 2 == 0).Select(n => n * n).ToList();	


			List<string> strings = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };
			
			// Using regular method to check if any string starts with 'a'
			bool startsWithA = AnyStartsWithALetter(strings, 'a');
			Console.WriteLine($"Any string starts with 'a': {startsWithA}");

			//Using LINQ with any to check if any string starts with 'a'
			bool startsWithALinq = strings.Any(s => s[0]=='a');




		}
	}
}
