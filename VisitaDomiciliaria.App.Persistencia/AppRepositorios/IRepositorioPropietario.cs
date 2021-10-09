using System.Collections.Generic;
using VisitaDomiciliaria.App.Dominio;

namespace VisitaDomiciliaria.App.Persistencia
{
    public interface IRepositorioPropietario
    {
        IEnumerable<Propietario> GetAllPropietarios();
        Propietario AddPropietario(Propietario propietario);
        Propietario UpdatePropietario(Propietario propietario);
        void DeletePropietario(int idPropietario);
        Propietario GetPropietaio(int idPropietario);
    }




}
