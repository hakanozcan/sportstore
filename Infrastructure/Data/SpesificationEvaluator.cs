using System.Linq;
using Core.Entities;
using Core.Spesifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SpesificationEvaluator<TEntity> where TEntity:BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpesification<TEntity> spec){
            var query =inputQuery;


            if (spec.Criteria!=null)
            {
                query=query.Where(spec.Criteria);
                                
            }
            query=spec.Includes.Aggregate(query,(current,include) => current.Include(include));
            return query;

        }
    }
}