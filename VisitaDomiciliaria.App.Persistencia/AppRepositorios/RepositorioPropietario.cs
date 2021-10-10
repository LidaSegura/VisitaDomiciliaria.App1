using System.Collections.Generic;
using System.Linq;
using System.VisitaDomiciliaria.App.Dominio;

namespace VisitaDomiciliaria.App.Persistencia
{
    public class RepositorioPropietario:IRepositorioPropietario
    {
        private readonly AppContext _appContext;

        public RepositorioPropietario(AppContext appContext)
        {
            _appContext = appContext;
        }


        Propietario IRepositorioPropietario.AddPropietario(Propietario propietario)
        {
            var propietarioAdicionado = _appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;

        }

        Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(c=> c.Id == propietario.Id);
            if (propietarioEncontrado =! null)
                {
                    propietarioEncontrado.idPropietario=propietario.idPropietario;
                    propietarioEncontrado.Nombres=propietario.Nombres;
                    propietarioEncontrado.Apellidos=propietario.Apellidos;
                    propietarioEncontrado.Telefono=propietario.Telefono;

                    _appContext.SaveChanges();
                }
            return propietarioEncontrado;
        }

        void IRepositorioPropietario.DeletePropietario(int idPersona)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(c => c.Id == idPersona);
            if (propietarioEncontrado == null)
                return;
            _appContext.Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
        }
        
        Propietario IRepositorioPropietario.GetPropietaio(int idPersona)
        {
            return _appContext.Propietarios.FirstOrDefault(c => c.Id == idPersona)
        }
        IEnumerable<Propietario> IRepositorioPropietarios.GetAllPropietarios()
        {
            return _appContext.Propietarios;
        }
    } 
}