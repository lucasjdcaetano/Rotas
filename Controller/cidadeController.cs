namespace Controller
{
    public class cidadeController
    {
        public static void CadastrarCidade (string id, string nome)
        {
            int idConvertido =0;
            try 
            {
                idConvertido = Int32.Parse(id);
            }catch (Exception)
            {
                throw new Exception("*** ID INVÁLIDO ***");
            }

            Model.cidadeModel caminhao = new Model.cidadeModel(idConvertido, nome);
        }
         public static void AlterarCidade (string id, string nome)
        {
            int idConvertido =0;
            try 
            {
                idConvertido = Int32.Parse(id);
            }catch (Exception)
            {
                throw new Exception("*** ID INVÁLIDO ***");
            }

            Model.cidadeModel.AlterarCidade(idConvertido, nome);
        }
        public static void ExcluirCidade (string id)
        {
            int idConvertido =0;
            try 
            {
                idConvertido = Int32.Parse(id);
            }catch (Exception)
            {
                throw new Exception("*** ID INVÁLIDO ***");
            }

            Model.cidadeModel.ExcluirCidade(idConvertido);
        }
        public static List<Model.cidadeModel> ListarCidades()
        {
            return Model.cidadeModel.Cidades;
        }
    }

}