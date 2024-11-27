using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoDeVenta.Domain.Entities;
using PuntoDeVenta.Infraestructura.Persistences.Contexto;
using PuntoDeVenta.Infraestructura.Persistences.Interfaces;

namespace PuntoDeVenta.Infraestructura.Persistences.Repositorios
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly SisventasContext _context;

        public CategoryRepository(SisventasContext context)
        {
            _context = context;
        }
    }
}
