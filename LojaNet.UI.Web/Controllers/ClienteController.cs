using LojaNet.BLL;
using LojaNet.Models;
using System;
using System.Web.Mvc;

namespace LojaNet.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteBLL bll;
        public ClienteController()
        {
            this.bll = new ClienteBLL();
        }

        public ActionResult Excluir(string id)
        {
            return View(bll.ObterPorId(id));
        }

        [HttpPost]
        public ActionResult Excluir(string id, FormCollection form)
        {
            try
            {
                bll.Excluir(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(bll.ObterPorId(id));
            }
        }

        public ActionResult Alterar(string id)
        {
            return View(bll.ObterPorId(id));
        }

        [HttpPost]
        public ActionResult Alterar(Cliente cliente)
        {
            try
            {
                bll.Alterar(cliente);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(cliente);
            }
        }

        public ActionResult Detalhes(string id)
        {
            return View(bll.ObterPorId(id));
        }

        public ActionResult Incluir()
        {
            return View(new Cliente());
        }
        
        [HttpPost]
        public ActionResult Incluir(Cliente cliente)
        {
            try
            {
                bll.Incluir(cliente);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(cliente);
            }  
        }

        // GET: Cliente
        public ActionResult Index()
        {
            return View(bll.ObterTodos());
        }
    }
}