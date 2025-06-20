using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample;

// מחלקה המייצגת ציון עם תכונה פרטית לשמירת הציון
public class Grade
{
	private int _score;//תכונה פרטית לשמירת הציון

	// מאפיין ציבורי לגישה לציון
	public int Score
	{
		get
		{
			return _score;
		}
		set 
		{
			if (value >= 0 && value <= 100) //בדיקה אם הציון בטווח תקין
				_score = value;
			else
				{
				// זריקת חריגה במקרה שהציון מחוץ לטווח 0-100
				throw new ArgumentOutOfRangeException(nameof(value), "ציון חייב להיות בין 0 ל-100");
			}

		}
	}
	public string? Subject
	{
		get; set;} //מאפיין ציבורי לשמירת נושא הציון
	  
	//טקסט המייצג את הציון באותיות	
	public string LetterGrade
	{
		get
		{
			if (Score >= 90)
				return "A";
			else if (Score >= 80)
				return "B";
			else if (Score >= 70)
				return "C";
			else if (Score >= 60)
				return "D";
			else
				return "F";
		}
	}


	/// <summary>
	/// בונה של מחלקת Grade עם ציון.
	/// </summary>
	/// <param name="score"></param>
	public Grade(int score)
	{
		Score = score; //הגדרת הציון באמצעות המאפיין
	}
}

