//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWLNBazarHub.EnlaceDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetallesPedido
    {
        public int DetalleID { get; set; }
        public Nullable<int> PedidoID { get; set; }
        public Nullable<int> ProductoID { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> PrecioUnitario { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> FechaDeEdicion { get; set; }
    
        public virtual Pedidos Pedidos { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
