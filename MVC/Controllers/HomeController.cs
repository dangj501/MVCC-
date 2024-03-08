using Microsoft.AspNetCore.Mvc;
namespace MVC;
public class HomeController : Controller
{

private readonly IDataContext _context;
 
public HomeController(IDataContext context)
{
    _context = context;
}
public async Task<IActionResult> Index()
{
// obtiene la lista de productos
List<Producto> productos = await _context.ObtenProductosAsync();
// Envía el modelo a la vista
return View(productos);
}
public ActionResult Error(){
    return View();
}


}