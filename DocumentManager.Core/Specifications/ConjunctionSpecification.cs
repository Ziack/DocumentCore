namespace DocumentManager.Core.Specifications
{
    using System.Collections.Generic;
    using System.Linq;
    using DocumentManager.Core.Schema;

    public class ConjunctionSpecification<T> : CompositeSpecification<T>
    {
        #region Fields

        private readonly ISpecification<T>[] _conjunction;

        #endregion

        #region Constructors and Destructors

        public ConjunctionSpecification(params ISpecification<T>[] conjunction)
        {
            this._conjunction = conjunction;
        }

        #endregion

        #region Public Methods and Operators

        public override bool IsSatisfiedBy(T candidate, ref IList<string> errorMessages, ref IList<Rules> rules)
        {
            foreach (ISpecification<T> spec in this._conjunction)
            {
                if (!spec.IsSatisfiedBy(candidate, ref errorMessages, ref rules))
                    return false;
            }

            return true;
        }

        #endregion
    }
}