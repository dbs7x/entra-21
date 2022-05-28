using Entra21.ExerciciosOrientacaoObjetos.Exercicio01;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;

Console.WriteLine(@"-----MENU-----
1 - Exercicio 01
2 - Exercicio 02
");

Console.WriteLine("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    ExemploLivro exemplolivro = new ExemploLivro();
    exemplolivro.Executar();
}
if (opcaoDesejada == 2)
{
    ExemploTemperatura exemplotemperatura = new ExemploTemperatura();
    exemplotemperatura.Executar();
}