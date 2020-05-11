
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorQuery
{
    public class BlazorQueryUtils
    {
        private readonly IJSRuntime _jsRuntime;
        public BlazorQueryUtils(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public BlazorQueryUtils Alert(string message)  { _jsRuntime.InvokeAsync<Task>(BlazorQueryList.Utils_Alert, message); return this; }
        public BlazorQueryUtils ConsoleLog(string message) { _jsRuntime.InvokeAsync<Task>(BlazorQueryList.Utils_ConsoleLog, message); return this; }
    }
}
