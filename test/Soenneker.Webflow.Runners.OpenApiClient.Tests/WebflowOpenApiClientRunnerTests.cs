using Soenneker.Tests.HostedUnit;

namespace Soenneker.Webflow.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class WebflowOpenApiClientRunnerTests : HostedUnitTest
{
    public WebflowOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
