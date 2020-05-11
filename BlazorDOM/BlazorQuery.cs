using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorQuery
{
    public class BlazorQuery : ComponentBase
    {
        private IJSRuntime _jsRuntime { get; set; }
        public BlazorQueryUtils Utils { get; } 

        public BlazorQuery(IJSRuntime JSRuntime)
        {
            _jsRuntime = JSRuntime;
            Utils = new BlazorQueryUtils(JSRuntime);
        }

        public BlazorQueryDOM Select(string selector)
        {
            //make singleton factory;
            BlazorQueryDOM dom = new BlazorQueryDOM(_jsRuntime, selector);
            
            return dom;
        }
    }
}
