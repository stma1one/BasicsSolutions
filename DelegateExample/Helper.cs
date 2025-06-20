using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateExample;

    internal static class Helper

    {
	#region void method not parameter

	/// <summary>
	/// מדפיס הודעת הצלחה לקונסול.
	/// </summary>
	public static void Success()
        {
            Console.WriteLine("This is Success Message");
        }

	/// <summary>
	/// מדפיס הודעת הצלחה לקונסול.
	/// </summary>
	public static void MadeIt()
        {
            Console.WriteLine("WE DID IT!");
        }
	#endregion


	#region void method with parameter
	/// <summary>
	/// מדפיס הודעת כישלון לקונסול.
	/// </summary>
	/// <param name="message"></param>
	public static void Failed(string message)
        {
            Console.WriteLine($"Unable to process : {message}");
        }
	#endregion


	#region Return value methods

	/// <summary>
	/// מחזיר אמת אם התו הוא ספרה (0-9), אחרת מחזיר שקר.
	/// </summary>
	/// <param name="ch"></param>
	/// <returns></returns>
	public static bool IsDigit(char ch)
        {
            return ch >= '0' && ch <= '9';
        }

	/// <summary>
	/// מחזיר אמת אם התו הוא אות (a-z או A-Z), אחרת מחזיר שקר.
	/// </summary>
	/// <param name="ch"></param>
	/// <returns></returns>
	public static bool IsLetter(char ch)
        {
            return (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch < 'Z');
        }

	/// <summary>
	/// מחזיר אמת אם הרשימה מכילה אפס, אחרת מחזיר שקר.
	/// </summary>
	/// <param name="arr"></param>
	/// <returns></returns>
	public static bool ContainsZero(List<int> arr)
        {
			Console.WriteLine("ContainsNumber:");
           foreach(int i in arr)
            {
                if (i == 0)
                    return true;
			}
           return false;
		}

	/// <summary>
	/// מחזיר אמת אם הרשימה מכילה ספרה (0-9), אחרת מחזיר שקר.
	/// </summary>
	/// <param name="arr"></param>
	/// <returns></returns>
	public static bool ContainsDigit(List<int> arr)
        {
			Console.WriteLine("ContainsDigit:");
			foreach (int i in arr)
            {
                if (i <10 && i>=0)
                    return true;
			}
            return false;   
		}

	/// מכפיל שני מספרים שלמים ומחזיר את התוצאה.
	/// </summary>
	/// <param name="a"></param>
	/// <param name="b"></param>
	/// <returns></returns>
	public static int Multiply(int a, int b)
	{
		return a * b;
	}

	#endregion
	#region Any and All methods
	public static bool AnyLetters(List<string> ls)
	{
		for (int i = 0; i < ls.Count; i++)
			foreach (char c in ls[i])
			{
				if (IsLetter(c))
					return true;
			}
		return false;
	}

	public static bool AllDigits(List<string> ls)
	{
		for (int i = 0; i < ls.Count; i++)
			foreach (char c in ls[i])
			{
				if (!IsDigit(c))
					return false;
			}
		return true;
	}
	#endregion


}

