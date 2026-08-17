namespace MeuTeste
{
	public class Curso
	{
		public string Name {get;set;}
		public List<Pessoa> Alunos {get;set;}

		public void AdicionaAluno(Pessoa aluno)
		{
			Alunos.Add(aluno);
		}

		public int QtdDeAlunos()
		{
			int qtd = Alunos.Count;
			return qtd;
		}

		public void RemoverAluno(Pessoa aluno)
		{
			Alunos.Remove(aluno);
		}

		public void ListarAlunos()
		{
			Console.WriteLine($"Alunos do curso de {Name}:");
			for (int i = 0; i < Alunos.Count; i++)
			{
				string texto = $"N* {i+1} - {Alunos[i].NomeCompleto}";
				Console.WriteLine(texto);
			}
		}
	}
}