namespace MeuTeste
{
	public class Pessoa
	{
		public Pessoa(){}

		public Pessoa(string nome, string sobrenome){
			Name = nome;
			Sobrenome = sobrenome;
		}
		private string _name = string.Empty;
		private string _sobrenome = string.Empty;
		private int _idade;
		public string Name
		{
			get => _name;
			set
			{
				if (value == "")
				{
					throw new ArgumentException("o nome não pode ser vazio!");
				}
				_name = value;
			}
		}
		public string Sobrenome
		{
			get => _sobrenome;
			set
			{
				if (value == "")
				{
					throw new ArgumentException("o sobrenome não pode ser vazio!");
				}
				_sobrenome = value;
			}
		}
		public int Idade
		{
			get => _idade; 
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("A idade não pode ser menor quer zero!");
				}
				_idade = value;
			}
		}

		public string NomeCompleto => $"{Name} {Sobrenome}".ToUpper();

		public void Apresentar()
		{
			Console.WriteLine($"{NomeCompleto} possui {Idade} anos");
		}
	}
}