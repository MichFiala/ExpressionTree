using Application.Builders;
using Client.Keys;
using Client.Variables;
using Newtonsoft.Json;
using TreeStructure;

var initValues = new (IExpressionRootKey, decimal)[]
{
	(new TriangleSideVariablesKey(TriangleAttributes.LengthAttributesSegment, TriangleSideVariables.SideALength), 2),
	(new TriangleSideVariablesKey(TriangleAttributes.LengthAttributesSegment, TriangleSideVariables.SideBLength), 4),
	(new TriangleSideVariablesKey(TriangleAttributes.LengthAttributesSegment, TriangleSideVariables.HeightALength), 6),
	// (new TriangleSideVariablesKey(TriangleAttributes.Length, TriangleSideVariables.SideCLength), 8),
};

var formulasBuilder = new TriangleFormulasBuilder(initValues);

var formula = formulasBuilder.BuildPeripheryFormula();

Console.WriteLine(JsonConvert.SerializeObject(formula));

formula = formulasBuilder.BuildAreaFormula();

Console.WriteLine(JsonConvert.SerializeObject(formula));





