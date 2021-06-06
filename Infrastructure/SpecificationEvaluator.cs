using System;
using System.Linq;
using System.Linq.Expressions;
using Core.Entities;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class SpecificationEvaluator<T> where T : BaseEntity
    {
        public static IQueryable<T> GetQueryable(IQueryable<T> inputQuery,ISpecification<T> specification)
        {
            var query=inputQuery;
            if(specification.Criteria!=null){
                query=query.Where(specification.Criteria);
            }
            query=specification.Includes.Aggregate(query,(current,include)=>current.Include(include));

            return query;
        }
    }
}