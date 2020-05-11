

using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorQuery
{
    public class BlazorQueryFunctions : BlazorQuaryWrapBase
    {
        public BlazorQueryFunctions(IJSRuntime jsRuntime, string currentSelector, BlazorQueryDOM blazorQuery) : base(jsRuntime, currentSelector, blazorQuery)
        {
        }

        public BlazorQueryFunctions AddClass(string className) { _jsRuntime.InvokeAsync<Task>(BlazorQueryList.AddClass, currentSelector, className); return this; }
        public BlazorQueryFunctions RemoveClass(string className) {  _jsRuntime.InvokeAsync<Task>(BlazorQueryList.RemoveClass, currentSelector, className); return this; }
        public BlazorQueryFunctions CSS(string style, string styleValue) { _jsRuntime.InvokeAsync<Task>(BlazorQueryList.CSS, currentSelector, style, styleValue); return this; }
        public BlazorQueryFunctions Height(int height) { _jsRuntime.InvokeAsync<Task>(BlazorQueryList.Height_Set, currentSelector, height); return this; }
        public BlazorQueryFunctions Width(int width) { _jsRuntime.InvokeAsync<Task>(BlazorQueryList.Width_Set, currentSelector, width); return this; }
        public BlazorQueryFunctions Text(string text) { _jsRuntime.InvokeAsync<Task>(BlazorQueryList.Text_Set, currentSelector, text); return this; }

        public async Task<string> GetChildren() { return await _jsRuntime.InvokeAsync<string>(BlazorQueryList.GetChildren, currentSelector); }
    }
}
