using AspNet_Live_CICD.Services;
using Moq;
using Shouldly;
using System.Linq;
using System.Reflection;
using Xunit;

namespace AspNet_Live_CICD.Test
{
    public class UnitTest1
    {
        private Mock<ActionService> _actionServiceMock;

        public UnitTest1()
        {
            _actionServiceMock = new Mock<ActionService>();
        }

        [Fact]
        public void Test1()
        {
            // Act
            var result = _actionServiceMock.Object.Get();

            // Assert
            result.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void TestPrivateMethod()
        {
            MethodInfo dynMethod = typeof(ActionService).GetMethod("DoSomething", BindingFlags.NonPublic | BindingFlags.Instance);
            dynMethod.Invoke(_actionServiceMock.Object, null);

            Assert.True(true);
        }
    }
}
