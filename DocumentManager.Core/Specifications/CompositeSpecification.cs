using System;
using System.Collections.Generic;
using DocumentManager.Core.Schema;
namespace DocumentManager.Core.Specifications
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        #region Public Methods and Operators

        public ISpecification<T> And(ISpecification<T> other)
        {
            return new AndSpecification<T>(this, other);
        }

        public abstract bool IsSatisfiedBy(T candidate, ref IList<String> errorMessages, ref IList<Rules> rules);

        public ISpecification<T> Not()
        {
            return new NotSpecification<T>(this);
        }

        public ISpecification<T> Or(ISpecification<T> other)
        {
            return new OrSpecification<T>(this, other);
        }
        #endregion
    }
}