namespace Principal
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            Model.cidadeModel jlle = new Model.cidadeModel(1, "Joinville");
            Model.cidadeModel jra = new Model.cidadeModel(2, "Jaragua");
            Model.caminhaoModel caminhao = new Model.caminhaoModel(1, "MEU-5857", "João");
            new Model.rotaModel(1,DateTime.Parse("2022-12-12"),jlle,jra,caminhao);
            Console.WriteLine("Rastreio de Caminhões: ");
            int opcao = 0;
            do {
                Console.WriteLine("1 - Cadastrar Rota");
                Console.WriteLine("2 - Alterar Rota");
                Console.WriteLine("3 - Excluir Rota");
                Console.WriteLine("4 - Listar Rotas");
                Console.WriteLine("5 - Cadastrar Caminhão");
                Console.WriteLine("6 - Alterar Caminhão");
                Console.WriteLine("7 - Excluir Caminhão");
                Console.WriteLine("8 - Listar Caminhões");
                Console.WriteLine("9 - Cadastrar Cidade");
                Console.WriteLine("10 - Alterar Cidade");
                Console.WriteLine("11 - Excluir Cidade");
                Console.WriteLine("12 - Listar Cidades");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Opção:");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        View.rotaView.CadastrarRota();
                        break;
                    case 2:
                        View.rotaView.AlterarRota();
                        break;
                    case 3:
                        View.rotaView.ExcluirRota();
                        break;
                    case 4:
                        View.rotaView.ListarRotas();
                        break;
                    case 5:
                        View.caminhaoView.CadastrarCaminhao();
                        break;
                    case 6:
                        View.caminhaoView.AlterarCaminhao();
                        break;
                    case 7:
                        View.caminhaoView.ExcluirCaminhao();
                        break;
                    case 8:
                        View.caminhaoView.ListarCaminhoes();
                        break;
                    case 9:
                        View.cidadeView.CadastrarCidade();
                        break;
                    case 10:
                        View.cidadeView.AlterarCidade();
                        break;
                    case 11:
                        View.cidadeView.ExcluirCidade();
                        break;
                    case 12:
                        View.cidadeView.ListarCidades();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}