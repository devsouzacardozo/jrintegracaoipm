using jrintegracaoipm.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Controllers
    {
    public class LancamentoController : Controller
        {
        private readonly LancamentoService _lancamentoService;

        public LancamentoController( LancamentoService lancamentoService )
            {
            _lancamentoService = lancamentoService;
            }

        public IActionResult Index()
            {
            var list = _lancamentoService.FindAll();
            return View(list);
            }
        }
    }
