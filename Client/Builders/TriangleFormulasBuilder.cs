using Application.Expressions;
using Application.ExpressionsSolvers;
using Application.Stores;
using Client.Keys;
using Client.Variables;
using TreeStructure;

namespace Application.Builders
{
	public class TriangleFormulasBuilder
	{
		private readonly ExpressionNodeSolverFacade _solverFacade;
		public TriangleFormulasBuilder((ExpressionRootKey Key, decimal Value)[]? initValues, IValuesStore valuesStore)
		{
			var solverFactory = new ExpressionSolverFactory(valuesStore);

			if (initValues is not null)
				foreach (var (key, value) in initValues) valuesStore.AddValue(key, value);

			_solverFacade = new ExpressionNodeSolverFacade(solverFactory);
		}

		public IExpressionNode BuildPeripheryFormula()
		{
			var sideALength = new ReferenceExpression(
				new TriangleSideVariablesKey(TriangleAttributes.LengthAttributesSegment, TriangleSideVariables.SideALength));
			var sideBLength = new ReferenceExpression(
				new TriangleSideVariablesKey(TriangleAttributes.LengthAttributesSegment, TriangleSideVariables.SideBLength));
			var sideCLength = new ReferenceExpression(
				new TriangleSideVariablesKey(TriangleAttributes.LengthAttributesSegment, TriangleSideVariables.SideCLength));

			var expression = new BinomialExpression(sideALength, Operators.BinomialOperatorEnum.Plus,
					new BinomialExpression(sideBLength, Operators.BinomialOperatorEnum.Plus, sideCLength));

			var rootKey = new TrianglePeripheryVariablesKey(TriangleAttributes.PeripheryAttributesSegment, TrianglePeripheryVariables.Periphery);
			var rootExpression = new RootExpression(rootKey, expression);

			var solvedExression = _solverFacade.Solve(rootExpression);

			return ((RootExpression)solvedExression).Node;
		}

		public IExpressionNode BuildAreaFormula()
		{
			var sideALength = new ReferenceExpression(
				new TriangleSideVariablesKey(TriangleAttributes.LengthAttributesSegment, TriangleSideVariables.SideALength));
			var heightALength = new ReferenceExpression(
				new TriangleSideVariablesKey(TriangleAttributes.LengthAttributesSegment, TriangleSideVariables.HeightALength));

			var expression = new BinomialExpression(
				new BinomialExpression(
					sideALength,
					Operators.BinomialOperatorEnum.Multiplication,
					heightALength
				),
				Operators.BinomialOperatorEnum.Division,
				new ConstantExpression { Value = 2 });

			var rootKey = new TriangleAreaVariablesKey(TriangleAttributes.AreaAttributesSegment, TriangleAreaVariables.Area);
			var rootExpression = new RootExpression(rootKey, expression);

			var solvedExression = _solverFacade.Solve(rootExpression);

			return ((RootExpression)solvedExression).Node;
		}
	}
}