namespace Springboard365.Xrm.UnitTest.Core
{
    using Microsoft.Xrm.Sdk;
    using Moq;

    public static class PluginExecutionContextExtensions
    {
        public static Mock<IPluginExecutionContext> WithInputParameters(this Mock<IPluginExecutionContext> pluginContextMock, ParameterCollection parameterCollection)
        {
            pluginContextMock
                .Setup(context => context.InputParameters)
                .Returns(parameterCollection);
            
            return pluginContextMock;
        }

        public static Mock<IPluginExecutionContext> WithPreEntityImages(this Mock<IPluginExecutionContext> pluginContextMock, EntityImageCollection entityImageCollection)
        {
            pluginContextMock
                .Setup(context => context.PreEntityImages)
                .Returns(entityImageCollection);

            return pluginContextMock;
        }

        public static Mock<IPluginExecutionContext> WithPostEntityImages(this Mock<IPluginExecutionContext> pluginContextMock, EntityImageCollection entityImageCollection)
        {
            pluginContextMock
                .Setup(context => context.PostEntityImages)
                .Returns(entityImageCollection);

            return pluginContextMock;
        }

        public static Mock<IPluginExecutionContext> WithDefault(this Mock<IPluginExecutionContext> pluginContextMock)
        {
            pluginContextMock
                .Setup(context => context.PostEntityImages)
                .Returns(new EntityImageCollection());

            return pluginContextMock;
        }
    }
}