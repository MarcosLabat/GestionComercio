﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public Articulo() { Id = -1; }
        public int Id { get; set; } 
        public string Codigo { get; set; } 
        public string Descripcion { get; set;}
        public string Nombre { get; set; }
        public float Precio { get; set; }   
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public Imagen Imagen { get; set; }
        
    }
}
