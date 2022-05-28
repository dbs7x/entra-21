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
        - ApresentarQuantidadeAnosAposPublicação
        Criar classe de ExercicioLivro que instancie o livro e atribua valor para suas propriedades,
        assim como chamar os métodos.*/

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
            Console.Write("Título: " + Titulo + "\nAutor: " + Autor);
        }

        public void ApresentarQuantidadePaginasParaLer()
        {
            Console.WriteLine("Quantidade de páginas para ler: " + (QuantidadePaginas - QuantidadePaginasLidas));
        }

        public void ApresentarQuantidadePaginasLidasNoTotal()
        {
            Console.WriteLine("Quantidade total de páginas lidas: " + (QuantidadePaginasLidas * QuantidadeReleituras));
        }

        public void ApresentarQuantidadeAnosAposPublicação()
        {
            Console.WriteLine("Quantidade de anos após publicação: " + (DateTime.Now.Year - DataLancamento.Year));
        }
    }
}
