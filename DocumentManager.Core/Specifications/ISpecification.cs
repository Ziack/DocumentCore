using System;
using System.Collections.Generic;
using DocumentManager.Core.Schema;
namespace DocumentManager.Core.Specifications
{
    public interface ISpecification<T>
    {
        #region Public Methods and Operators

        ISpecification<T> And(ISpecification<T> other);

        bool IsSatisfiedBy(T candidate, ref IList<String> errorMessages, ref IList<Rules> rules);

        ISpecification<T> Not();

        ISpecification<T> Or(ISpecification<T> other);

        #endregion
    }
}