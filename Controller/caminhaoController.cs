namespace Controller
{
    public class caminhaoController
    {
        public static void CadastrarCaminhao(string id, string placa, string motorista)
        {
            int idConvertido =0;
            try 
            {
                idConvertido = Int32.Parse(id);
            }catch (Exception)
            {
                throw new Exception("Id inválido");
            }

            Model.caminhaoModel caminhao = new Model.caminhaoModel(idConvertido, placa, motorista);
        }
        public static void AlterarCaminhao(string id, string placa, string motorista)
        {
            int idConvertido =0;
            try 
            {
                idConvertido = Int32.Parse(id);
            }catch (Exception)
            {
                throw new Exception("*** ID INVÁLIDO ***");
            }

            Model.caminhaoModel.AlterarCaminhao(idConvertido, placa, motorista);
        }
        public static void ExcluirCaminhao(string id)
        {
            int idConvertido =0;
            try 
            {
                idConvertido = Int32.Parse(id);
            }catch (Exception)
            {
                throw new Exception("*** ID INVÁLIDO ***");
            }

            Model.caminhaoModel.ExcluirCaminhao(idConvertido);
        }
        public static void BuscarCaminhao(string id)
        {
            int idConvertido =0;
            try 
            {
                idConvertido = Int32.Parse(id);
            }catch (Exception)
            {
                throw new Exception("*** ID INVÁLIDO ***");
            }

            Model.caminhaoModel.BuscarCaminhao(idConvertido);
        }
        public static List<Model.caminhaoModel> ListarCaminhoes()
        {
            return Model.caminhaoModel.Caminhoes;
        }
    }
}
