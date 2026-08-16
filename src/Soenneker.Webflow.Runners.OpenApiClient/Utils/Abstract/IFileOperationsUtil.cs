using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Webflow.Runners.OpenApiClient.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(CancellationToken cancellationToken = default);
}
