namespace View
{

    public class caminhaoView
    {
        public static void CadastrarCaminhao()
        {
            Console.WriteLine("CADASTRO DE CAMINHÃO");
            Console.WriteLine("Informe o Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Informe a Placa:");
            string placa = Console.ReadLine();
            Console.WriteLine("Informe o Motorista:");
            string motorista = Console.ReadLine();
            try 
            {
                Controller.caminhaoController.CadastrarCaminhao(id, placa, motorista);
                Console.WriteLine("O caminhão foi cadastrado!");
            }catch (Exception e) 
            {
                Console.WriteLine($"Erro de cadastro: {e.Message}");
            }
        }
        public static void AlterarCaminhao()
        {
            Console.WriteLine("ALTERAÇÃO DE CAMINHÃO");
            Console.WriteLine("Informe o Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Informe a Placa:");
            string placa = Console.ReadLine();
            Console.WriteLine("Informe o Motorista:");
            string motorista = Console.ReadLine();
            try 
            {
                Controller.caminhaoController.AlterarCaminhao(id, placa, motorista);
                Console.WriteLine("O caminhão foi alterado!");
            }catch (Exception e) 
            {
                Console.WriteLine($"Erro de alteração: {e.Message}");
            }
        }
        public static void ExcluirCaminhao()
        {
            Console.WriteLine("EXCLUSÃO DE CAMINHÃO");
            Console.WriteLine("Informe o Id:");
            string id = Console.ReadLine();
            
            try 
            {
                Controller.caminhaoController.ExcluirCaminhao(id);
                Console.WriteLine("O caminhão foi excluído!");
            }catch (Exception e) 
            {
                Console.WriteLine($"Erro de exclusão: {e.Message}");
            }
        }
        public static void ListarCaminhoes()
        {
            Console.WriteLine("Listagem de caminhões:");
            foreach (Model.caminhaoModel caminhao in Controller.caminhaoController.ListarCaminhoes())
            {
                Console.WriteLine(caminhao);
            }
        }
    }
}