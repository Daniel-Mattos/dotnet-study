// MeuTeste.SwitchCase.VerificarVogal("a");
// MeuTeste.Condicional.VerificarNumero(10);
// MeuTeste.Laco.Tabuada(2);
// MeuTeste.Calculadora.Somar(10,20);
// MeuTeste.Calculadora.Seno(30);
// MeuTeste.Calculadora.Cos(45);
// MeuTeste.Calculadora.Tangente(90);
// MeuTeste.Array.ExemploArray();
// MeuTeste.Array.ForEach();
//MeuTeste.Estacionamento.Executar();
using MeuTeste;

// Pessoa p1 = new Pessoa();
// p1.Name = "dan";
// p1.Sobrenome = "tes";
// p1.Idade = 21;
// p1.Apresentar();

// Pessoa p2 = new Pessoa();
// p2.Name = "nad";
// p2.Sobrenome = "set";

Pessoa p1 = new Pessoa(nome:"Ten",sobrenome:"teste");
Pessoa p2 = new Pessoa(nome:"Dan",sobrenome:"teste");

Curso mat = new Curso();
mat.Name="Matematica";
mat.Alunos= new List<Pessoa>();

mat.AdicionaAluno(p1);
mat.AdicionaAluno(p2);
mat.ListarAlunos();