using Microsoft.AspNet.OData.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Yoisoft.Util
{
    public static class ODataQueryOptionsExtensions
    {
        public static Expression<Func<TElement, bool>> ToExpression<TElement>(this FilterQueryOption filter)
        {
            var param = Expression.Parameter(typeof(TElement));
            IQueryable queryable = Enumerable.Empty<TElement>().AsQueryable();
            if (filter != null)
            {
                queryable = filter.ApplyTo(queryable, new ODataQuerySettings());
                var mce = queryable.Expression as MethodCallExpression;
                if (mce != null)
                {
                    var quote = mce.Arguments[1] as UnaryExpression;
                    if (quote != null)
                    {
                        return quote.Operand as Expression<Func<TElement, bool>>;
                    }
                }

            }
            return Expression.Lambda<Func<TElement, bool>>(Expression.Constant(true), param);
        }
        public static Expression<Func<TElement, bool>> ToExpression<TElement>(this OrderByQueryOption orderBy)
        {
            var param = Expression.Parameter(typeof(TElement));
            IQueryable queryable = Enumerable.Empty<TElement>().AsQueryable();
            if (orderBy != null)
            {
                queryable = orderBy.ApplyTo(queryable, new ODataQuerySettings());
                var mce = queryable.Expression as MethodCallExpression;
                if (mce != null)
                {
                    var quote = mce.Arguments[1] as UnaryExpression;
                    if (quote != null)
                    {
                        return quote.Operand as Expression<Func<TElement, bool>>;
                    }
                }

            }
            return Expression.Lambda<Func<TElement, bool>>(Expression.Constant(true), param);
        }
    }

}
