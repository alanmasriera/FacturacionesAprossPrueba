using Facturaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturaciones.DAL
{
    public class FacturasRepository
    {
        public IEnumerable<Facturas> GetFacturasPorPrestador(string nombreAutor)
        {
            var facturas = new Facturas();
            using(FacturasEntities2 contexto = new FacturasEntities2())
            {
                return contexto.Facturas.Where(f => f.nombre_autor == nombreAutor).ToList();
            }
        }
        public IEnumerable<Facturas> GetFacturas()
        {
            var facturas = new Facturas();
            using (FacturasEntities2 contexto = new FacturasEntities2())
            {
                return contexto.Facturas.AsNoTracking().ToList();
            }
        }
    }
}