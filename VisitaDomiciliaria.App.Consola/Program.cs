using System;
using VisitaDomiciliaria.App.Dominio;
using VisitaDomiciliaria.App.Persistencia;

namespace VisitaDomiciliaria.App.Consola
{
    class Program
    {
        private static IRepositorioPropietario _repoPropietario = new  RepositorioPropietario(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPropietario();
        }   Buscarpropietario(1);

        private static void AddPropietario()
        {
            var propietario = new Propietario()
            {
                idPropietario  = "123",
                Nombres = "HOMERO J",
                Apellidos = "SIMPSON",
                Telefono = "5555" ,
                Direccion = "Avenida Siempre Viva 123",
                Correo = "homero@simpson.co"
            };
            _repoPropietario.AddPropietario(propietario);
        }
    }

    private static void Buscarpropietario(int idPropietario)
    {
        var propietario = _repoPropietario.GetPropietaio(idPropietario);
        Console.WriteLine(propietario.nombres);
    }


}
