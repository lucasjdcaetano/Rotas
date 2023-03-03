namespace View
{
    public class rotaView
    {
        public static void CadastrarRota()
        {
            Console.WriteLine("CADASTRO DE ROTA");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Data:");
            string data = Console.ReadLine();
            Console.WriteLine("Partida:");
            string partidaId = Console.ReadLine();
            Console.WriteLine("Destino:");
            string destinoId = Console.ReadLine();
            Console.WriteLine("Caminhão:");
            string caminhaoId = Console.ReadLine();   
            try {
                Controller.rotasController.CadastrarRota(id, partidaId, destinoId, caminhaoId, data);
                Console.WriteLine("A rota foi cadastrada!");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }        
            
        }
        public static void AlterarRota()
        {
            Console.WriteLine("ALTERAÇÃO DE ROTA");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Data:");
            string data = Console.ReadLine();
            Console.WriteLine("Partida:");
            string partidaId = Console.ReadLine();
            Console.WriteLine("Destino:");
            string destinoId = Console.ReadLine();
            Console.WriteLine("Caminhão:");
            string caminhaoId = Console.ReadLine();   
            try {
                Controller.rotasController.AlterarRota(id, partidaId, destinoId, caminhaoId, data);
                Console.WriteLine("A rota foi cadastrada!");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }        
            
        }
        public static void ExcluirRota()
        {
            Console.WriteLine("EXCLUSÃO DE ROTA");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
              
            try {
                Controller.rotasController.ExcluirRota(id);
                Console.WriteLine("A rota foi cadastrada!");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }        
            
        }
        public static void ListarRotas()
        {
            Console.WriteLine("Listagem de Rotas:");
            foreach(string rota in Controller.rotasController.ListarRotas())
            {
                Console.WriteLine(rota);
            }
        }
    }
}