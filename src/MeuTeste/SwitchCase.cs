using System;

public class SwitchCase
{
	public static string VerificarVogal(string letra)
	{
		switch (letra)
		{
			case "a":
				return $"{letra} é uma vogal";
			case "e":
				return $"{letra} é uma vogal";
			case "i":
				return $"{letra} é uma vogal";
			case "o":
				return $"{letra} é uma vogal";
			case "u":
				return $"{letra} é uma vogal";
			default: 
				return $"{letra} não é uma vogal";
		}
	}
}