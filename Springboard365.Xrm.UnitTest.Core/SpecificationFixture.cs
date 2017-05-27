namespace Springboard365.Xrm.UnitTest.Core
{
    using System;
    using Moq;

    public class SpecificationFixture<TUnderTest>
        where TUnderTest : class
    {
        public SpecificationFixture()
        {
            ServiceProvider = ServiceProviderInitializer.Setup().WithDefault();

            UnderTest = (TUnderTest)Activator.CreateInstance(typeof(TUnderTest));
        }

        public TUnderTest UnderTest { get; set; }

        public Mock<IServiceProvider> ServiceProvider { get; set; }

        public virtual void PerformTestSetup()
        {
        }
    }
}