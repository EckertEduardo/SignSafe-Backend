﻿using System.Linq.Expressions;

namespace SignSafe.Domain.Extensions
{
    public static class QueryExtensions
    {
        public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> source, bool condition, Expression<Func<TSource, bool>> predicate)
        {
            return condition ? source.Where(predicate) : source;
        }
    }
}
