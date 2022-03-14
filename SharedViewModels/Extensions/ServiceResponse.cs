using System.Net;
using System.Text;
using SharedViewModels.Constants;

namespace SharedViewModels.Extensions;
public class ServiceResponse
{
    public ServiceResponseConstants Code { get; set; }
    public string? Message { get; set; }
    public Exception? RespException { get; set; }
    public object? Data { get; set; }

}