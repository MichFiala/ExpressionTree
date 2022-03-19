// See https://aka.ms/new-console-template for more information
using Application;
using Application.Expressions;
using Application.ExpressionsSolvers;
using Application.Variables;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

WindsorContainer container = new WindsorContainer();

container.Register(
	Component.For<IExpressionNodeSolverForMarker<BinomialExpression>>()
	.ImplementedBy<BinomialExpressionSolver>()
	.LifestyleTransient());

container.Register(
	Component.For<IExpressionNodeSolverForMarker<VariableExpression>>()
	.ImplementedBy<VariableExpressionSolver>()
	.LifestyleTransient());

container.Register(
	Component.For<IExpressionNodeSolverForMarker<ConstantExpression>>()
	.ImplementedBy<ConstantExpressionSolver>()
	.LifestyleTransient());

container.Register(
	Component.For<ExpressionNodeSolverFactory>()
	.Instance(new ExpressionNodeSolverFactory(container))
	.LifestyleSingleton());
var solverFactory = container.Resolve<ExpressionNodeSolverFactory>();

var grossIncomeExpression = new ConstantExpression(new CalculationVariableExpressionKey("Risk", CalculationVariablesEnum.GrossIncome), 1000);
var taxExpression = new ConstantExpression(new CalculationVariableExpressionKey("Risk", CalculationVariablesEnum.Tax), 1 - 0.3m);



var incomeExpression = new BinomialExpression(
	new CalculationVariableExpressionKey("Risk", CalculationVariablesEnum.Income),
	grossIncomeExpression,
	Application.Operators.BinomialOperatorEnum.Multiplication,
	taxExpression);

bool couldBeSolved = solverFactory.TrySolve(incomeExpression, out decimal result);

Console.WriteLine($"{couldBeSolved}- {result}");


