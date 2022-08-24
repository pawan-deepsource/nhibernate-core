using System.Linq.Expressions;
using NHibernate.Linq.Visitors;

namespace NHibernate.Linq.Expressions
{
	public abstract class NhExpression : Expression
	{
		public sealed override ExpressionType NodeType => ExpressionType.Extension;

		protected sealed override Expression Accept(ExpressionVisitor visitor)
		{
			if (visitor is NhExpressionVisitor nhVisitor)
				return Accept(nhVisitor);

			return base.Accept(visitor);
		}

		protected abstract Expression Accept(NhExpressionVisitor visitor);
	}
}
