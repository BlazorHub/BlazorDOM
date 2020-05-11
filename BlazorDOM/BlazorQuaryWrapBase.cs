

using Microsoft.JSInterop;

namespace BlazorQuery
{
    public class BlazorQuaryWrapBase 
    {

        protected IJSRuntime _jsRuntime;
        protected string currentSelector;
        public BlazorQueryDOM ret;

        public BlazorQuaryWrapBase(IJSRuntime jsRuntime, string currentSelector, BlazorQueryDOM blazorQueryDOM)
        {
            _jsRuntime = jsRuntime;
            this.currentSelector = currentSelector;
            ret = blazorQueryDOM;
        }
    }
}
