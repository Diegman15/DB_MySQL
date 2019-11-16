using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DB_CRUD.Mercado
{
    class Traspasos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Jugador { get; set; }
        public string Precio { get; set; }
        public string Equipo_Salida { get; set; }
        public string Equipo_Entrada { get; set; }

        public override string ToString()
        {
            return $"{Jugador} - {Precio} - {Equipo_Salida}-{Equipo_Entrada}";
        }
    }
}
