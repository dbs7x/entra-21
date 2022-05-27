using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio01
{
    public class Livro
    {
        /*Crie uma classe chamada Livro para armazenar as seguintes informações
        - Título
        - Autor
        - Código ISBN
        - Idioma original
        - Data de lançamento
        - Quantidade de páginas
        - Quantidade de páginas lidas
        - Quantidade de releituras
        Crie os seguintes métodos:
        - ApresentarTituloAutor
        - ApresentarQuantidadePaginasParaLer
        - ApresentarQuantidadePaginasLidasNoTotal
        Criar testes unitários validando os métodos criados acima*/

        public string Titulo;
        public string Autor;
        public string CodigoIsbn;
        public string Idioma;
        public DateTime DataLancamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int QuantidadeReleituras;

        public void ApresentarTituloAutor()
        {
            Console.WriteLine(Titulo + " " + Autor);
        }

        public void ApresentarQuantidadePaginasParaLer()
        {
            Console.WriteLine(QuantidadePaginas);
        }




    }
}
