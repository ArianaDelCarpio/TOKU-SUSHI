//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int id_usuario { get; set; }
        public string contrasenia { get; set; }
        public string rol { get; set; }
        public string nombre_usuario { get; set; }
        public Nullable<int> cliente_id { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
