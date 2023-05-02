using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComercio
{
    internal class Imagen
    {
        public int Id { get; set; }
        public string UrlImagen{ get; set; }
        public override string ToString()
        {
            return UrlImagen;
        }
    }
}
