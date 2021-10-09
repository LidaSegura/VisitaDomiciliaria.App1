using System;
namespace VisitaDomiciliaria.App.Dominio
{
    public class Visita
    {
        public int Id {get;set;}
        public Gato Gato {get;set;}
        public Veterinario Veterinario {get;set;}
        public string FechaVisita {get;set;}
        public string Temperatura {get;set;}
        public string Peso {get;set;}
        public string FrecuenciaRespiratoria {get;set;}
        public string FrecuenciaCardiaca {get;set;}
        public string EstadoAnimo {get;set;}
        public string Recomendaciones {get;set;}
    }
}