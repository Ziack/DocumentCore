using System.Collections.Generic;
using DocumentManager.Core.Schema;
namespace DocumentManager.Core.Specifications
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        #region Fields

        private readonly ISpecification<T> _a;

        private readonly ISpecification<T> _b;

        #endregion

        #region Constructors and Destructors

        public AndSpecification(ISpecification<T> a, ISpecification<T> b)
        {
            this._a = a;
            this._b = b;
        }

        #endregion

        #region Public Methods and Operators

        public override bool IsSatisfiedBy(T candidate, ref IList<string> errorMessages, ref IList<Rules> rules)
        {
            var IsSatisfiedByA = this._a.IsSatisfiedBy(candidate, ref errorMessages, ref rules);
            var IsSatisfiedByB = this._b.IsSatisfiedBy(candidate, ref errorMessages, ref rules);

            return IsSatisfiedByA && IsSatisfiedByB;
        }

        #endregion        
    }
}