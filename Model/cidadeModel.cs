using System;
namespace Model
{
    public class cidadeModel
    {
        public int Id {get; set;}
        public string Nome {get; set;}

        public static List<cidadeModel> Cidades {get; set;} = new List<cidadeModel>();

        public cidadeModel (int id, string nome)
        {
            Id= id;
            Nome= nome;

            Cidades.Add(this);
        
        }
        public override string ToString()
        {
            return $"Id: {Id} \r\nNome: {Nome}";
        }
        public static cidadeModel BuscarCidade(int id)
        {
            cidadeModel? cidade = Cidades.Find(c => c.Id ==id);
            if(cidade == null)
            {
                throw new Exception("CAMINHÃO NÃO ENCONTRADO");
            }
            return cidade;
        }
        public static void AlterarCidade(int id, string nome)
        {
            cidadeModel cidade = BuscarCidade(id);
            cidade.Nome = nome;
        }
        public static void ExcluirCidade(int id)
        {
            cidadeModel cidade = BuscarCidade(id);
            Cidades.Remove(cidade);
        }
    }

}