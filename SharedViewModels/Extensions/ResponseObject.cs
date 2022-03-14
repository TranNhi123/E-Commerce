using System.Net;
using System.Text;
using SharedViewModels.Constants;

namespace SharedViewModels.Extensions;
public class ResponseObject
{
    public string? Message { get; set; }
    public object? Data { get; set; }
}