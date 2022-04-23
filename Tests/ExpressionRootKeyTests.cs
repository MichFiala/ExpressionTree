using FluentAssertions;
using TreeStructure;
using Xunit;

namespace Tests
{
	public class ExpressionRootKeyTests
    {
        [Fact]
        public void EqualityTest()
        {
			var key1 = new ConcreteExpressionRootKey("A", "B");
            var key2 = new ConcreteExpressionRootKey("A", "B");
            
			key1.Equals(key2).Should().BeTrue();
		}

        [Fact]
        public void DifferentOrderEqualityTest()
        {
			var key1 = new ConcreteExpressionRootKey("B", "B");
            var key2 = new ConcreteExpressionRootKey("A", "B");
            
			key1.Equals(key2).Should().BeFalse();
		}

        [Fact]
        public void DifferentEnumsEqualityTest()
        {
			var key1 = new ConcreteExpressionRootKey(ConcreteExpressionRootKey.A.A);
            var key2 = new ConcreteExpressionRootKey(ConcreteExpressionRootKey.B.A);
            
			key1.Equals(key2).Should().BeFalse();
		}
        [Fact]
        public void ContainsTest()
        {
            var key1 = new ConcreteExpressionRootKey(
                ConcreteExpressionRootKey.A.A,
                ConcreteExpressionRootKey.B.B,
                "A",
                "Test"    
            );

			key1.Contains("A").Should().BeTrue();
            key1.Contains("TestA").Should().BeFalse();
            key1.Contains(ConcreteExpressionRootKey.A.A).Should().BeTrue();
            key1.Contains(ConcreteExpressionRootKey.B.B).Should().BeTrue();
            key1.Contains(ConcreteExpressionRootKey.B.A).Should().BeFalse();
		}
        public class ConcreteExpressionRootKey : ExpressionRootKey
        {
            public ConcreteExpressionRootKey(params object[] keyParts) : base(keyParts){}

            public enum A {
                A,
                B
            }

            public enum B {
                A,
                B
            }
        }
    }
}