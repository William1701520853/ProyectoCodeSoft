//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos1.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class calificacione
    {
        public int id_calificacion { get; set; }
        public int id_servicio { get; set; }
        public int id_cliente { get; set; }
        public int calificacion { get; set; }
        public string comentario { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual servicio servicio { get; set; }
    }
}