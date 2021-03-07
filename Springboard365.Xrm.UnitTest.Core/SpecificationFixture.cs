namespace Springboard365.Xrm.UnitTest.Core
{
    using System;
    using Moq;
    using Springboard365.UnitTest.Core;

    public abstract class PluginSpecificationFixture<TUnderTest> : SpecificationFixture<TUnderTest>
        where TUnderTest : class
    {
        protected PluginSpecificationFixture()
        {
            ServiceProvider = ServiceProviderInitializer.Setup().WithDefault();
        }

        public Mock<IServiceProvider> ServiceProvider { get; set; }
    }
}