 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;   
using Exemplo_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExemploMVC.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            //Criar uma referencia para o PessoaModel
            PessoaModel pModel = new PessoaModel();

            //Executar o étodo Listar()
            
            return View(pModel.Listar());
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pessoa/Create
        [HttpGet]
        public ActionResult Create()
        {
            // A view agora está relacionada com o modelo
            return View(new PessoaModel());
        }

        // POST: Pessoa/Create
        [HttpPost]
        public ActionResult Create(PessoaModel pModel)
        {
            pModel.Salvar();

            return RedirectToAction("Index");
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pessoa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}