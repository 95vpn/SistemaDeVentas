using PuntoDeVenta.Infraestructura.Commons.Bases;


namespace PuntoDeVenta.Infraestructura.Helpers
{
    public static class QuerableHelper
    {
        public static IQueryable<T>Paginate<T>(this IQueryable <T> queryable, BasePaginationRequest request)
        {
            return queryable.Skip((request.NumPage - 1) * request.Records).Take(request.Records);
        }
    }
}
