using Facturaciones.DAL;
using Facturaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using MongoDbAPI.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Facturaciones.Controllers
{
    public class FacturasController : Controller
    {
        FacturasRepository repo = new FacturasRepository();
        //ItemFacturableCollection repo2 = new ItemFacturableCollection();
        // GET: Facturas
        public async Task<ActionResult> Index()
        {
            //IEnumerable<Facturas> lista = repo.GetFacturasPorPrestador("Alan Masriera");
            //return View(lista);
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://localhost:7110/api/itemFacturable");
            List<ItemFacturable> itemsFacturables = JsonConvert.DeserializeObject<List<ItemFacturable>>(json);
            return View(itemsFacturables);
        }

        // GET: Facturas/Details/5

    }
}
