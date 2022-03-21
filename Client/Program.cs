// See https://aka.ms/new-console-template for more information
using Application;
using Application.Expressions;
using Application.ExpressionsSolvers;
using Application.Keys;
using Application.Stores;
using Application.Variables;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

WindsorContainer container = new WindsorContainer();

container.Register(
	Component.For<IExpressionNodeSolverForMarker<BinomialExpression>>()
	.ImplementedBy<BinomialExpressionSolver>()
	.LifestyleTransient());

container.Register(
	Component.For<IExpressionNodeSolverForMarker<ReferenceExpression>>()
	.ImplementedBy<ReferenceExpressionSolver>()
	.LifestyleTransient());

container.Register(
	Component.For<IExpressionNodeSolverForMarker<ConstantExpression>>()
	.ImplementedBy<ConstantExpressionSolver>()
	.LifestyleTransient());

container.Register(
	Component.For<IExpressionNodeSolverForMarker<RootExpression>>()
	.ImplementedBy<RootExpressionSolver>()
	.LifestyleTransient());

container.Register(
	Component.For<IValuesStore>()
	.ImplementedBy<ValuesStore>()
	.LifestyleSingleton());

container.Register(
	Component.For<ExpressionNodeSolverFactory>()
	.Instance(new ExpressionNodeSolverFactory(container))
	.LifestyleSingleton());
var solverFactory = container.Resolve<ExpressionNodeSolverFactory>();

var grossIncomeExpression = new ConstantExpression("GrossIncomeValue", 1000);
var taxExpression = new ConstantExpression("TaxValue", 1 - 0.3m);

var incomeExpression = new BinomialExpression(
	"GrossIncomeToTaxValue",
	grossIncomeExpression,
	Application.Operators.BinomialOperatorEnum.Multiplication,
	taxExpression);

var incomeRootExpression = new RootExpression(
	new CalculationVariableExpressionKey("2021", CalculationVariablesEnum.Income),
	"IncomeValue",
	incomeExpression);

bool couldBeSolved = solverFactory.TrySolve(incomeRootExpression, out decimal result);

Console.WriteLine($"{couldBeSolved} - {result}");


var expressionWithPredifinedVariable = new BinomialExpression(
	"PredifinedVariableExpression",
	new ConstantExpression("A", 10),
	Application.Operators.BinomialOperatorEnum.Plus,
	new ReferenceExpression("PredefinedVariableReference", new PredefinedVariableExpressionKey("Pi")));

var predefinedRootExpression = new RootExpression(new CalculationVariableExpressionKey("Test", CalculationVariablesEnum.GrossIncome), "TestExpression", expressionWithPredifinedVariable);

var valueStore = container.Resolve<IValuesStore>();
valueStore.AddValue(new PredefinedVariableExpressionKey("Pi"), 3.14m);

var solved = solverFactory.TrySolve(predefinedRootExpression, out decimal resultWithPredifinedValue);

Console.WriteLine($"{solved} - {resultWithPredifinedValue}");

var expressionWithPredefinedAndCalculated = new BinomialExpression(
	"PredifinedVariableWithCalculatedExpression",
	new ReferenceExpression("GrossIncome", new CalculationVariableExpressionKey("Test", CalculationVariablesEnum.GrossIncome)),
	Application.Operators.BinomialOperatorEnum.Minus,
	new ReferenceExpression("PredefinedVariableReference", new PredefinedVariableExpressionKey("Pi")));

solved = solverFactory.TrySolve(expressionWithPredefinedAndCalculated, out decimal resultWithPredifinedAndCalculatedValue);

Console.WriteLine($"{solved} - {resultWithPredifinedAndCalculatedValue}");




