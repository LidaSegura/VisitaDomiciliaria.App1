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

        }
        void IRepositorioPropietario.DeletePropietario(int idPropietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirtOrDefault(c => c.Id == idPropietario);
            if (clienteEncontrado == null)
                return;
            _appContext.Propietarios.Remove(clienteEncontrado);
            _appContext.SaveChanges();
            


        }
        Propietario IRepositorioPropietario.GetPropietaio(int idPropietario)
        {
            return _appContext.Propietarios.FirtOrDefault(c => c.Id == idPropietario)

        }
        IEnumerable<Propietario> IRepositorioPropietarios.GetAllPropietarios()
        {
            return _appContext.Propietarios;
        }
    } 
}