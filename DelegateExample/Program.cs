
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;


namespace DelegateExample;


//Delegate- מצביע לפעולות
//Action - void delegate
//Action<type1,type2>
//Func<return type> - return value delegate
//Func<In types,return type>
//Predicate<in Type (single)>


#region Declare delegate
//delegate for void methods
public delegate void PrintMessageDelegate();/// <summary>
		

public delegate void PrintTextMessageDelegate(string m);
//delegate for return value methods 
public delegate bool CheckDelegate(char c);
#endregion

internal class Program
    {

        public static void Main(string[] args)
        {

			List<int> list = [123, 456, 543, 666];

		//יצירת משתנה מסוג Delegate שמצביע על פונקציה מסוג void ללא פרמטרים
		PrintMessageDelegate print1;
		//הפניית המשתנה לפונקציה Success
		print1 = Helper.Success;
		//הפעלת הפונקציה דרך המשתנה
		print1();
		
		Console.Clear();
		//הוספת פונקציה נוספת למשתנה multi-cast
		print1 += Helper.MadeIt;
		//שימוש בפונקצית invocation של המשתנה להפעיל את כל הפונקציות המצביעות עליו
		print1.Invoke();
		//הסרת פונקציה מהמשתנה multi-cast
		print1 -= Helper.Success;
		print1.Invoke();

		PrintTextMessageDelegate printm = Helper.Failed;
			//if (printm != null)
			//{
			//    printm("Oi, Oi,Oi");
			//}
			printm?.Invoke("Oi,Oi,OI");

			CheckDelegate charsCheck = Helper.IsDigit;
			charsCheck += Helper.IsLetter;
			Console.WriteLine(charsCheck('8'));

		//ם פונקציה מסוג Action ללא פרמטרים
		Action successMessage = Helper.Success;
			successMessage?.Invoke();

		//delegate עבור פונקציה מסוג Action עם פרמטר מסוג string
			Action<string> printText = Helper.Failed;
			printText("Oi, Oi, Oi");

		//Func עבור פונקציה מסוג Func עם שני פרמטרים מסוג int והחזרת ערך מסוג int
		//הערך האחרון של Func הוא תוצאת החישוב
		Func<int,int,int> calc = Helper.Multiply;
		int result = calc(5, 10);
		Console.WriteLine($"Result : {result}");
		Func<List<int>, bool> checkZero = Helper.ContainsZero;
		Console.WriteLine(checkZero(list));
		
		//זהה את ה- Func עם פרמטר מסוג List<int> והחזרת ערך מסוג bool
		Predicate<List<int>> checkZero2 = Helper.ContainsZero;
		Console.WriteLine(checkZero2(list));
		
		//תרגיל
		Func<char, bool> checkChar = Helper.IsDigit;
			Console.WriteLine( checkChar('A')); 
			
		
		List<string> strings = new List<string>() { "123", "456", "543", "666" };
		
		Predicate<List<string>> checkStrings = Helper.AnyLetters;
		Console.WriteLine(	 checkStrings(strings));
		checkStrings=Helper.AllDigits;
		Console.WriteLine(checkStrings(strings));

			
		CheckStrings(strings, Helper.AllDigits, Helper.MadeIt, Helper.Failed);
		CheckStrings(strings, Helper.AnyLetters, Helper.Success, Helper.Failed);

		//CheckStrings(list, delegate (List<string> strings) { return strings.Count <0; }, delegate () { Console.WriteLine("Success"); }, delegate (string m) { Console.WriteLine(m); });
		//CheckStrings(list, (strings) => strings.Count <0, () => Console.WriteLine("Success"),  (string m) => Console.WriteLine(m) );
	}
	public static void CheckStrings(List<string> strings, Predicate<List<string>> check, Action success, Action<string> failed)
		{
			if (check(strings))
			{
				success();
			}
			else
			{
				failed("No Strings Found");
			}
	}



}

