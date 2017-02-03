using System.Collections.Generic;
using DocumentManager.Core.Schema;
namespace DocumentManager.Core.Specifications
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        #region Fields

        private readonly ISpecification<T> _wrapped;

        #endregion

        #region Constructors and Destructors

        public NotSpecification(ISpecification<T> wrapped)
        {
            this._wrapped = wrapped;
        }

        #endregion

        #region Public Methods and Operators

        public override bool IsSatisfiedBy(T candidate, ref IList<string> errorMessages, ref IList<Rules> rules)
        {
            return !this._wrapped.IsSatisfiedBy(candidate, ref errorMessages, ref rules);
        }

        #endregion
    }
}