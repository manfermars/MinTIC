using System;
using System.Collections.Generic;

namespace Dominio{
    public  class ColegioInstruccion{
        public int Id{get;set;}
        public string Nit{get;set;}
        public string Nombre{get;set;}
        public string Reglamentacion{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}
        public string Correo{get;set;}
        public string Disciplina{get;set;}
        //Propiedad navigacional con tabla Arbitro
        public List <Arbitro> Arbitros{get;set;}       
    }
}