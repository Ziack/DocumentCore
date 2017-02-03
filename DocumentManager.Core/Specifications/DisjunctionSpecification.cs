namespace DocumentManager.Core.Specifications
{
    using System.Collections.Generic;
    using System.Linq;
    using DocumentManager.Core.Schema;

    public class DisjunctionSpecification<T> : CompositeSpecification<T>
    {
        #region Fields

        private readonly ISpecification<T>[] _disjunction;

        #endregion

        #region Constructors and Destructors

        public DisjunctionSpecification(ISpecification<T>[] disjunction)
        {
            this._disjunction = disjunction;
        }

        #endregion

        #region Public Methods and Operators

        public override bool IsSatisfiedBy(T candidate, ref IList<string> errorMessages, ref IList<Rules> rules)
        {
            foreach(ISpecification<T> spec in this._disjunction)
            {
                if (spec.IsSatisfiedBy(candidate, ref errorMessages, ref rules))
                    return true;
            }
                         
            return false;
        }

        #endregion
    }
}