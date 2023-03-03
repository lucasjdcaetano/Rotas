namespace Controller
{
    public class rotasController
    {
        public static void CadastrarRota(string id, string data, string partidaId, string destinoId, string caminhaoId)
        {
            int idConvertido =0;
            try
            {
                idConvertido = Int32.Parse(id);
            }catch (Exception)
            {
                throw new Exception("*** ID INVÁLIDO ***");
            } 
            
            int partidaIdConvertido = 0; 
            try {
                partidaIdConvertido = int.Parse(partidaId);
            } catch (Exception) {
                throw new Exception("*** ID INVÁLIDO ***");

            DateTime dataConvertida = DateTime.Parse(data);
            Model.cidadeModel partida = Model.cidadeModel.BuscarCidade(partidaIdConvertido);
            Model.cidadeModel destino = Model.cidadeModel.BuscarCidade(Int32.Parse(destinoId));
            Model.caminhaoModel caminhao = Model.caminhaoModel.BuscarCaminhao(Int32.Parse(caminhaoId));
            Model.rotaModel rota = new Model.rotaModel(idConvertido, dataConvertida, partida, destino, caminhao);
            }
        }
        public static void AlterarRota (string id, string data, string partidaId, string destinoId, string caminhaoId)
        {
            int idConvertido =0;
            try 
            {
                idConvertido = Int32.Parse(id);
            }catch (Exception)
            {
                throw new Exception("*** ID INVÁLIDO ***");
            }

            DateTime dataConvertida = DateTime.Parse(data);
            Model.cidadeModel partida = Model.cidadeModel.BuscarCidade(int.Parse(partidaId));
            Model.cidadeModel destino = Model.cidadeModel.BuscarCidade(Int32.Parse(destinoId));
            Model.caminhaoModel caminhao = Model.caminhaoModel.BuscarCaminhao(Int32.Parse(caminhaoId));
            Model.rotaModel rota = new Model.rotaModel(idConvertido, dataConvertida, partida, destino, caminhao);
        }
        public static void ExcluirRota (string id)
        {
            int idConvertido =0;
            try 
            {
                idConvertido = Int32.Parse(id);
            }catch (Exception)
            {
                throw new Exception("*** ID INVÁLIDO ***");
            }

            Model.rotaModel.ExcluirRota(idConvertido);
        }
        public static Model.rotaModel BuscarRota(string id)
        {
            int idConvertido = 0;
            try {
                idConvertido = Int32.Parse(id);
            } catch (Exception) {
                throw new Exception("*** ID INVÁLIDO ***");
            }
            
            return Model.rotaModel.BuscarRota(idConvertido);
        }
        public static List<string> ListarRotas()
        {
            List<string> stringRotas = new List<string>();
            IEnumerable<Model.rotaModel> rotas = from rota in Model.rotaModel.Rotas
            join partida in Model.cidadeModel.Cidades on rota._partidaId equals partida.Id
            join destino in Model.cidadeModel.Cidades on rota._destinoId equals destino.Id
            join caminhao in Model.caminhaoModel.Caminhoes on rota._caminhaoId equals caminhao.Id
            select rota;


            foreach (Model.rotaModel rota in rotas)
            {
                stringRotas.Add($"Id: {rota.Id} \r\nData: {rota.Data} \r\nPartida: {rota.Partida.Nome} \r\nDestino: {rota.Destino.Nome} \r\nCaminhão: {rota.Caminhao.Placa}");
            }

            return stringRotas;

        }

    }
}