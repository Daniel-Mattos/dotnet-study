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
			foreach(Pessoa aluno in Alunos)
			{
				Console.WriteLine(aluno.NomeCompleto);
			}
		}
	}
}