using System;
namespace Model
{
    public class rotaModel
    {
        public int Id {get; set;}
        public DateTime Data {get; set;}
        public int _partidaId;
        public int _destinoId;
        public int _caminhaoId;
        public cidadeModel Partida {get; set;}
        public cidadeModel Destino {get; set;}
        public caminhaoModel Caminhao {get; set;}

        public static List<rotaModel> Rotas {get; set;} = new List<rotaModel>();

        public rotaModel (int id, DateTime data, cidadeModel partida, cidadeModel destino, caminhaoModel caminhao)
        {
            Id= id;
            Data= data;
            Partida = partida;
            _partidaId = partida.Id;
            Destino = destino;
            _destinoId = destino.Id;
            Caminhao = caminhao;
            _caminhaoId = caminhao.Id;


            Rotas.Add(this);
        }
        public override string ToString()
        {
             return $"Id: {Id} \r\nData: {Data} \r\nPartida: {Partida} \r\nDestino: {Destino} \r\nCaminhao: {Caminhao}";
        }
        public static rotaModel BuscarRota(int id)
        {
            rotaModel? rota = Rotas.Find (c => c.Id ==id);
            if(rota == null)
            {
                throw new Exception("ROTA NÃO ENCONTRADA");
            }
            return rota;
        }
        public static void AlterarRota(int id, DateTime data, cidadeModel partida, cidadeModel destino, caminhaoModel caminhao)
        {
            rotaModel rota = BuscarRota(id);
            rota.Data = data;
            rota.Partida = partida;
            rota.Destino = destino;
            rota.Caminhao = caminhao;
        }
        public static void ExcluirRota(int id)
        {
            rotaModel rota = BuscarRota(id);
            Rotas.Remove(rota);
        }
    }
}