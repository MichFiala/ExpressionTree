// See https://aka.ms/new-console-template for more information
using Application;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

WindsorContainer container = new WindsorContainer();

container.Register(
	Component.For<IExpressionNodeSolver<BinomialExpression>>()
	.ImplementedBy<BinomialExpressionSolver>()
	.LifestyleTransient());

container.Register(
	Component.For<IExpressionNodeSolver<VariableExpression>>()
	.ImplementedBy<VariableExpressionSolver>()
	.LifestyleTransient());

container.Register(
	Component.For<ExpressionSolverFactory>()
	.Instance(new ExpressionSolverFactory(container))
	.LifestyleSingleton());
var solverFactory = container.Resolve<ExpressionSolverFactory>();

bool couldBeSolved = solverFactory.TrySolve(
     new VariableExpression(new CalculationVariableExpressionKey("Risk", CalculationVariablesEnum.Income), null), out decimal result);

Console.WriteLine(couldBeSolved);


