namespace View
{
    public class cidadeView
    {
        public static void CadastrarCidade()
        {
            Console.WriteLine("CADASTRO DE CIDADE");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            try 
            {
                Controller.cidadeController.CadastrarCidade(id, nome);
                Console.WriteLine("A cidade foi cadastrado!");
            }catch (Exception e) 
            {
                Console.WriteLine($"Erro de cadastro: {e.Message}");
            }
        }
        public static void AlterarCidade()
        {
            Console.WriteLine("ALTERAÇÃO DE CIDADE");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            try 
            {
                Controller.cidadeController.AlterarCidade(id, nome);
                Console.WriteLine("A cidade foi cadastrado!");
            }catch (Exception e) 
            {
                Console.WriteLine($"Erro de alteração: {e.Message}");
            }
        }
        public static void ExcluirCidade()
        {
            Console.WriteLine("EXCLUSÃO CIDADE");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            
            try 
            {
                Controller.cidadeController.ExcluirCidade(id);
                Console.WriteLine("A cidade foi excluída!");
            }catch (Exception e) 
            {
                Console.WriteLine($"Erro de exclusão: {e.Message}");
            }
        }
         public static void ListarCidades()
        {
            Console.WriteLine("Listagem de Cidades:");
            foreach(Model.cidadeModel rota in Controller.cidadeController.ListarCidades())
            {
                Console.WriteLine(rota);
            }
        }
    }
}