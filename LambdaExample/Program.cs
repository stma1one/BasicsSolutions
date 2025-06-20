namespace LambdaExample
{

	internal class Program
	{
		/// <summary>
		/// מדפיס הודעת הצלחה לקונסול.
		/// </summary>
		/// <param name="message"></param>
		public static void Success(string message)
		{
			Console.WriteLine($"Success: {message}");
		}
		/// <summary>
		/// מכפיל שני מספרים שלמים ומחזיר את התוצאה.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static int Multiply(int a, int b)
		{
			return a * b;
		}

		static void Main(string[] args)
		{

			Action<string> PrintMessage = Success;
			PrintMessage("Hello from Lambda Expression!");

			// anonymous expressions example
			PrintMessage = delegate (string message)
			{
				Console.WriteLine($"Lambda Success: {message}");
			};

			PrintMessage("Hello from Anonymous Expression!");

			// Using Func delegate to multiply two numbers
			Func<int, int, int> Calc = Multiply;
			int result = Calc(5, 10);
			Console.WriteLine($"Result : {result}");
			// Anonymous delegate add two numbers
			Func<int, int, int> add = delegate (int x, int y) { return x + y; };

			//using lambda expression to print a message
			PrintMessage = (message) => Console.WriteLine($"Lambda Success: {message}");

			//using lambda expression to multiply two numbers
			Func<int, int, int> multiply = (x, y) => x * y;

		}

		//העברת פונקציה מסוג Func כפרמטר לפונקציה
		public static void CoolMethod(int a, int b, Func<int, int, int> operation, Action<string> successCallback, Action<string> failureCallback)
		{
			int? result = operation?.Invoke(a, b);
			if (result != null && result < 10)
			{
				successCallback?.Invoke($"The result is: {result}");
			}
			else
			{
				failureCallback?.Invoke("The result is not valid or is null.");

			}
		}

	}
}
