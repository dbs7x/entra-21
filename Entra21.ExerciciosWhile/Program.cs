using Entra21.ExerciciosWhile;

Console.WriteLine(@"-----MENU-----
1 - Exercicio 01
2 - Exercicio 02
3 - Exercicio 03
4 - Exercicio 04
5 - Exercicio 05
6 - Exercicio 06
7 - Exercicio 07
8 - Exercicio 08
9 - Exercicio 09
10 - Exercicio 10
11 - Exercicio 11");

Console.WriteLine("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 meuExemplo = new Exercicio01();
    meuExemplo.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio02 nossoExemplo = new Exercicio02();
    nossoExemplo.Executar();
}
else if (opcaoDesejada == 3)
{
    Exercicio03 meuExemplo = new Exercicio03();
    meuExemplo.Executar();
}
else if (opcaoDesejada == 4)
{
    Exercicio04 meuExemplo = new Exercicio04();
    meuExemplo.Executar();
}
else if (opcaoDesejada == 5)
{
    Exercicio05 meuExemplo = new Exercicio05();
    meuExemplo.Executar();
}
else if (opcaoDesejada == 6)
{
    Exercicio06 meuExemplo = new Exercicio06();
    meuExemplo.Executar();
}
else if (opcaoDesejada == 7)
{
    Exercicio07 meuExemplo = new Exercicio07();
    meuExemplo.Executar();
}
else if (opcaoDesejada == 8)
{
    Exercicio08 delesExemplo = new Exercicio08();
    delesExemplo.Executar();
}
else if (opcaoDesejada == 9)
{
    Exercicio09 delesExemplo = new Exercicio09();
    delesExemplo.Executar();
}