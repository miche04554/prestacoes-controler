//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cub
{
    using System;
    using System.Collections.Generic;
    
    public partial class pagamentos_tabela
    {
        public int id { get; set; }
        public int id_apartamento { get; set; }
        public string tipo { get; set; }
        public decimal valor { get; set; }
        public System.DateTime data { get; set; }
        public decimal valor_cub { get; set; }
    
        public virtual apartamentos_tabela apartamentos_tabela { get; set; }
    }
}
