namespace ExceptionExample;


internal class Program
{
	public static void ExceptionExample()
	{

		int[] arr = { 1, 2, 3 };
		try
		{
			Console.WriteLine(arr[5]); // This will throw an IndexOutOfRangeException
		}
		catch (IndexOutOfRangeException ex)
		{
			Console.WriteLine($"Caught an exception: {ex.Message}");
			throw; // Re-throwing the exception for further handling if needed
		}
		finally
		{
			Console.WriteLine("Finally block executed."); // This will always execute

		}
	}

	public static Grade CreateGrade(int score)
	{
		Grade? grade = null;
		try
		{
			grade = new Grade(score);
			grade.Subject = "Mathematics"; //הגדרת נושא הציון
			return grade; //אם הציון תקין, מחזיר את האובייקט Grade
		}
		catch (ArgumentOutOfRangeException ex)
		{
			throw new ArgumentOutOfRangeException($"Invalid score: {ex.Message}", ex); //מייצרת חריגה חדשה עם הודעה מותאמת אישית
		}
		
	}

	static void Main(string[] args)
	{
		// Exception handling example
		try
		{
			ExceptionExample();
		}
		//תפיסת חריגה ספציפית של IndexOutOfRangeException
		catch (IndexOutOfRangeException ex)
		{
			Console.WriteLine($"Caught an exception: {ex.Message}");
		}
		//תפיסת חריגה כללית של Exception
		catch (Exception ex)
		{
			Console.WriteLine($"Caught a general exception: {ex.Message}");
		}


		// Creating a Grade object with an invalid score
		Grade grade = CreateGrade(105);



	}
}
