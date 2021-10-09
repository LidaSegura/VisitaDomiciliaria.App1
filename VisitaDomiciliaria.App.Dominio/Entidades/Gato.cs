using System;
namespace VisitaDomiciliaria.App.Dominio
{
    public class Gato
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Raza {get;set;}
        public Propietario Propietario {get;set;}
    }
}