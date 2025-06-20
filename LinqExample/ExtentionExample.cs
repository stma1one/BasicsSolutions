using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
	public static class ExtentionExample
	{

		#region Extension Methods
		public static void MessageToIsrael(this string message)
		{
			// מדפיס הודעה לקונסול
			Console.WriteLine($"!דבל ורדסת :פמארט אישנהמ לארשיל העדוה");
		}
		public static List<int> FilterAndSquareEvenNumbers(this List<int> numbers)
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
		#endregion
	}
}
