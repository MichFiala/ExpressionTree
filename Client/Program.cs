using Application.Builders;
using Application.Stores;
using Client.Keys;
using Client.Variables;
using Newtonsoft.Json;
using TreeStructure;

var initValues = new (ExpressionRootKey, decimal)[]
{
	(new TriangleSideVariablesKey(TriangleAttributes.LengthAttributesSegment, TriangleSideVariables.SideALength), 2),
	(new TriangleSideVariablesKey(TriangleAttributes.LengthAttributesSegment, TriangleSideVariables.SideBLength), 4),
	// (new TriangleSideVariablesKey(TriangleAttributes.LengthAttributesSegment, TriangleSideVariables.HeightALength), 6),
	(new TriangleSideVariablesKey(TriangleAttributes.LengthAttributesSegment, TriangleSideVariables.SideCLength), 8),
};

var formulasBuilder = new TriangleFormulasBuilder(initValues, new ValuesStore());

var formula = formulasBuilder.BuildPeripheryFormula();

Console.WriteLine(JsonConvert.SerializeObject(formula, Formatting.Indented));

formula = formulasBuilder.BuildAreaFormula();

Console.WriteLine(JsonConvert.SerializeObject(formula, Formatting.Indented));





