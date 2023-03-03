using System;
namespace Model
{

    public class caminhaoModel
    {
        public int Id {get; set;}
        public string Placa {get; set;}
        public string Motorista {get; set;}

        public static List<caminhaoModel> Caminhoes {get; set;} = new List<caminhaoModel>();

        public caminhaoModel (int id, string placa, string motorista)
        {
            Id= id;
            Placa= placa;
            Motorista= motorista;

            Caminhoes.Add(this);
        }
        public override string ToString()
        {
            return $"Id: {Id} \r\nPlaca: {Placa} \r\nMotorista: {Motorista}";
        }
        public static caminhaoModel BuscarCaminhao(int id)
        {
            caminhaoModel? caminhao = Caminhoes.Find(c => c.Id == id);
            if (caminhao == null)
            {
                throw new Exception("Caminhão não encontrado");
            }
            return caminhao;
        }
        public static void AlterarCaminhao(int id, string placa, string motorista)
        {
            caminhaoModel caminhao = BuscarCaminhao(id);
            caminhao.Placa = placa;
            caminhao.Motorista = motorista;
        }
        public static void ExcluirCaminhao(int id)
        {
            caminhaoModel caminhao = BuscarCaminhao(id);
            Caminhoes.Remove(caminhao);
        }
    }

}