﻿using System.Linq.Dynamic.Core;
using PuntoDeVenta.Infraestructura.Commons.Bases;
using PuntoDeVenta.Infraestructura.Helpers;
using PuntoDeVenta.Infraestructura.Persistences.Interfaces;

namespace PuntoDeVenta.Infraestructura.Persistences.Repositorios
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected IQueryable<TDTO> Ordering<TDTO>(BasePaginationRequest request, IQueryable<TDTO> queryable, bool pagination = false) where TDTO : class
        {
            IQueryable<TDTO> queryDto = request.Order == "desc" ? queryable.OrderBy($"{request.Sort} descendig") : queryable.OrderBy($"{request.Sort} ascending");
            if (pagination) queryDto = queryDto.Paginate(request);
            return queryDto; 
        }
    }
}
