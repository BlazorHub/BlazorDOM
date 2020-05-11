

using Microsoft.JSInterop;

namespace BlazorQuery
{
    public class BlazorQueryDOM
    {

        public BlazorQueryFunctions Functions { get; }

        public BlazorQueryDOM(IJSRuntime jsRuntime, string selector)
        {

           Functions = new BlazorQueryFunctions(jsRuntime, selector, this);
        }
    }
}
