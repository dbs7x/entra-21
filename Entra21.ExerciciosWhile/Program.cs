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
11 - Exercicio 11
12 - Exercicio 12
13 - Exercicio 13");

Console.WriteLine("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
else if (opcaoDesejada == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
else if (opcaoDesejada == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
}
else if (opcaoDesejada == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if (opcaoDesejada == 6)
{
    Exercicio06 exercicio06 = new Exercicio06();
    exercicio06.Executar();
}
else if (opcaoDesejada == 7)
{
    Exercicio07 exercicio07 = new Exercicio07();
    exercicio07.Executar();
}
else if (opcaoDesejada == 8)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
else if (opcaoDesejada == 9) // Terminar
{
    Exercicio09 exercicio09 = new Exercicio09();
    exercicio09.Executar();
}
else if (opcaoDesejada == 10)
{
    Exercicio10 exercicio10 = new Exercicio10();
    exercicio10.Executar();
}
else if (opcaoDesejada == 11)
{
    Exercicio11 exercicio11 = new Exercicio11();
    exercicio11.Executar();
}
else if (opcaoDesejada == 12)
{
    Exercicio12 exercicio12 = new Exercicio12();
    exercicio12.Executar();
}
else if (opcaoDesejada == 13)
{
    Exercicio13 exercicio13 = new Exercicio13();
    exercicio13.Executar();
}