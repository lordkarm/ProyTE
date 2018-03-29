﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ProyTE.DATA
{
    //las facturas
    public class TbAlquileres
    {
        [AutoIncrement]
        public int Id_Alquiler { get; set; }

        public int Id_Usuario { get; set; }

        public string Estado { get; set; }

        public DateTime Entrega { get; set; }

        public DateTime Devuelve { get; set; }

        public decimal Precio { get; set; }

        public decimal? Multa { get; set; }

        public string Reparacion { get; set; }

        public string Detalle { get; set; }

        public DateTime FechaAlquiler { get; set; }
        //public

    }

}
