using jrintegracaoipm.Data;
using jrintegracaoipm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Service
    {
    public class LancamentoService
        {
        private readonly IntegracaoContext _context;

        public LancamentoService(IntegracaoContext context)
            {
            _context = context;
            }
         
        public List<Lancamento> FindAll()
            {
            return _context.Lancamentos.ToList();
            }
        }
    }
