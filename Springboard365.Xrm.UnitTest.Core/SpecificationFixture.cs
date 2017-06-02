namespace Springboard365.Xrm.UnitTest.Core
{
    using System;
    using Moq;
    using Springboard365.UnitTest.Core;

    public abstract class SpecificationFixture<TUnderTest> : SpecificationFixtureBase<TUnderTest>
        where TUnderTest : class
    {
        protected SpecificationFixture()
        {
            ServiceProvider = ServiceProviderInitializer.Setup().WithDefault();
        }

        public Mock<IServiceProvider> ServiceProvider { get; set; }
    }
}