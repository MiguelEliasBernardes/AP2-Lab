using System.Collections;
using System.Reflection.Emit;

Biblioteca bibli = new Biblioteca();

bool sis = true;
while(sis){

    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1 - Cadastrar Livro");
    Console.WriteLine("2 - Consulta livro");
    Console.WriteLine("3 - Atualiza informação Livro");
    Console.WriteLine("4 - Cadastro de usuário");
    Console.WriteLine("5 - Consulta de usuário");
    Console.WriteLine("6 - Atualiza usuário");
    Console.WriteLine("7 - Empréstimo de livro");
    Console.WriteLine("8 - Devolução de Livro");
    Console.WriteLine("0 - Sair");

    int Opc = Convert.ToInt32(Console.ReadLine());

    switch (Opc){
        case 0:
            sis = false;
            break;

        case 1:
            Console.WriteLine("---- Cadastro de livro ----");
            Console.WriteLine("");
            
            Console.WriteLine("Digite o titulo do livro: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o codigo do livro:");
            string codigo = Console.ReadLine();

            Console.WriteLine("Digite o autor do livro:");
            string autor = Console.ReadLine();

            Console.WriteLine("Digite o isbn do livro:");
            string isbn = Console.ReadLine();

            Console.WriteLine("Digite o genero do livro:");
            string genero = Console.ReadLine();

            Console.WriteLine("Digite a quantidade em estoque do livro:");
            int quantidadeemestoque = Convert.ToInt32(Console.ReadLine());


            Livro livro = new Livro(titulo, codigo, autor, isbn, genero, quantidadeemestoque);
            bibli.CadastrarLivro(livro);

            Console.WriteLine("");
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();

            break;


        case 2:
            Console.WriteLine("========================");
            Console.WriteLine("1 - Pesquisar por Titulo");
            Console.WriteLine("2 - Pesquisar por Autor");
            Console.WriteLine("3 - Pesquisar por Genero");
            Console.WriteLine("-- Por qual dado você deseja pesquisar o livro? ---");
            string dado = Console.ReadLine();

            switch(dado){
                case "1":
                    Console.WriteLine($"Digite o titulo do livro");
                    string tituloPesquisa = Console.ReadLine();
                    bibli.PesquisarPorTitulo(tituloPesquisa);
                    Console.WriteLine("Aperte ENTER para continuar");
                    Console.ReadLine();
                    break;
                
                case "2":
                    Console.WriteLine($"Digite o autor do livro");
                    tituloPesquisa = Console.ReadLine();
                    bibli.PesquisarPorAutor(tituloPesquisa);
                    Console.WriteLine("Aperte ENTER para continuar");
                    Console.ReadLine();
                    break;
                
                case "3":
                    Console.WriteLine($"Digite o genero do livro");
                    tituloPesquisa = Console.ReadLine();
                    bibli.PesquisarPorGenero(tituloPesquisa);
                    Console.WriteLine("Aperte ENTER para continuar");
                    Console.ReadLine();
                    break;
            }

            break;

        case 3:
            Console.WriteLine("---- Atualizar dados do livro ----");
            Console.WriteLine("");
            
            Console.WriteLine("Digite o titulo do livro: ");
            string tituloNovo = Console.ReadLine();

            Console.WriteLine("Digite o codigo do livro:");
            string codigoNovo = Console.ReadLine();

            Console.WriteLine("Digite o autor do livro:");
            string autorNovo = Console.ReadLine();

            Console.WriteLine("Digite o isbn do livro:");
            string isbnNovo = Console.ReadLine();

            Console.WriteLine("Digite o genero do livro:");
            string generoNovo = Console.ReadLine();

            Console.WriteLine("Digite a quantidade em estoque do livro:");
            int quantidadeemestoqueNovo = Convert.ToInt32(Console.ReadLine());

            bibli.AtualizarInformacoes(codigoNovo, tituloNovo, autorNovo, generoNovo, isbnNovo, quantidadeemestoqueNovo);

            break;

        case 4:
            Console.WriteLine("---- Cadastro de usuarios ----");
            Console.WriteLine("");
            
            Console.WriteLine("Digite o nome do usuario: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o numero de identificação do usuario:");
            string  numeroIdentificacao= Console.ReadLine();

            Console.WriteLine("Digite o endereço do usuário:");
            string endereco = Console.ReadLine();

            Console.WriteLine("Digite o contato do usuário:");
            string contato = Console.ReadLine();

            Usuario novoUsuario = new Usuario(nome, numeroIdentificacao, endereco, contato);

            bibli.CadastrarUsuario(novoUsuario);

            Console.WriteLine("");
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();


            break;

        case 5:
            bibli.ListarUsuarios();
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
            break;

        case 6:
            Console.WriteLine("---- Atualizar dados do usuário ----");
            Console.WriteLine("");

            Console.WriteLine("Digite o codigo do usuário:");
            codigoNovo = Console.ReadLine();

            Console.WriteLine("Digite o Nome do usuário:");
            string nomeNovo = Console.ReadLine();

            Console.WriteLine("Digite o endereço do usuário:");
            string enderecoNovo = Console.ReadLine();

            Console.WriteLine("Digite o contato do usuário:");
            string contatoNovo = Console.ReadLine();

            bibli.AtualizarInformacoes(codigoNovo, nomeNovo, enderecoNovo, contatoNovo);

            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();

            break;
        
        case 7:
            Console.WriteLine("---Emprestimo de livro---");
            Console.WriteLine("");
            Console.WriteLine("Digite o nome do livro:");
            string nomeLivro = Console.ReadLine();
            Console.WriteLine("Digite o nome do usuário:");
            string nomeUser = Console.ReadLine();

            bibli.EmprestarLivro(nomeLivro, nomeUser);
            break;
        case 8:

            Console.WriteLine("---Devolução de livro---");
            Console.WriteLine("");
            Console.WriteLine("Digite o nome do livro:");
            nomeLivro = Console.ReadLine();
            Console.WriteLine("Digite o nome do usuário:");
            nomeUser = Console.ReadLine();

            bibli.DevolverLivro(nomeLivro, nomeUser);
            break;

    }
    
}
