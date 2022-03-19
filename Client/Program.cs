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
	Component.For<ExpressionNodeSolverFactory>()
	.Instance(new ExpressionNodeSolverFactory(container))
	.LifestyleSingleton());
var solverFactory = container.Resolve<ExpressionNodeSolverFactory>();

var solver = solverFactory.GetExpressionSolver(new VariableExpression(new CalculationVariableExpressionKey("Risk", CalculationVariablesEnum.Income), null));
bool couldBeSolved = solverFactory.TrySolve(new VariableExpression(new CalculationVariableExpressionKey("Risk", CalculationVariablesEnum.Income), null), out decimal result);

Console.WriteLine(solver);
Console.WriteLine(couldBeSolved);


