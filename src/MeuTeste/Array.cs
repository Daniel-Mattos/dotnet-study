namespace MeuTeste
{
	public class Array
	{
		public static void ExemploArray()
		{
			string[] x = ["a","b","c"];
			int[] array = new int[3];

			array[0] = 10;
			array[1] = 20; 
			array[2] = 30;

			Console.WriteLine(x[1]);
			Console.WriteLine(array[1]);
		}

		public static void ForEach()
		{
			string[] x = ["a","b","c"];
			foreach(string valor in x)
			{
				Console.WriteLine(valor);
			}
			
		}
	}
}