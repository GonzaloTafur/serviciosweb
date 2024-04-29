using pe.com.tiendita.bal;
using pe.com.tiendita.bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace pe.com.tiendita.ws
{
    /// <summary>
    /// Descripción breve de TienditaWebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class TienditaWebServices : System.Web.Services.WebService
    {
        BALCategoria balcat = new BALCategoria();
        BALProducto balpro = new BALProducto();

        [WebMethod]
        public List<BOProducto> MostrarCategoria()
        {
            List<BOCategoria> productos = balcat.MostrarCategoria().ToList();
            return productos;
        }

        [WebMethod]
        public List<BOProducto> MostrarProductoTodo()
        {
            List<BOCategoria> categorias = balcat.MostrarCategoriaTodo().ToList();
            return categorias;
        }

        [WebMethod]
        public bool RegistrarProducto(BOCategoria bc)
        {
            return balcat.RegistrarCategoria(bc);
        }

        [WebMethod]
        public bool ActualizarProducto(BOProducto bc)
        {
            return balcat.ActualizarProducto(bc);
        }

        [WebMethod]
        public bool EliminarProducto(BOProducto bc)
        {
            return balcat.EliminarProducto(bc);
        }

        [WebMethod]
        public List<BOProducto> MostrarProducto()
        {
            List<BOProducto> productos = balpro.MostrarProducto().ToList();
            return productos;
        }
    }
}
