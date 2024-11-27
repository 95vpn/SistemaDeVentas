using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoDeVenta.Infraestructura.Persistences.Contexto;
using PuntoDeVenta.Infraestructura.Persistences.Interfaces;

namespace PuntoDeVenta.Infraestructura.Persistences.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SisventasContext _context;
        public ICategoryRepository Category {get; private set;}
        public UnitOfWork(SisventasContext context)
        {
            _context = context;
            Category = new CategoryRepository(_context);
        }


        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
