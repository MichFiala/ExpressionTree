using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public interface IExpressionNodeSolver
	{
		/// <summary>
		/// Solves expression 
		/// If all variables are available returns expression with decimal value
		/// </summary>
		/// <param name="node">Node to solve</param>
		/// <returns>Partially solved expression or fully solved expression</returns>
		IExpressionNode Solve(IExpressionNode node);
		/// <summary>
		/// Determines if solver is capable of solving node
		/// </summary>
		/// <param name="node">Node to determine if the solver can solve</param>
		/// <returns>Yes/No</returns>
		bool CanSolve(IExpressionNode node);
	}
}