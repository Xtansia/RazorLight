﻿using System;
using System.Dynamic;
using System.IO;
using System.Threading.Tasks;
using RazorLight.Caching;

namespace RazorLight
{
    public interface IRazorLightEngine
    {
        RazorLightOptions Options { get; }
        ICachingProvider TemplateCache { get; }

        Task<string> CompileRenderAsync<T>(string key, T model, ExpandoObject viewBag = null);
        Task<string> CompileRenderAsync(string key, object model, Type modelType, ExpandoObject viewBag);
        Task<ITemplatePage> CompileTemplateAsync(string key);
        Task<string> RenderTemplateAsync(ITemplatePage templatePage, object model, Type modelType, ExpandoObject viewBag = null);
        Task RenderTemplateAsync(ITemplatePage templatePage, object model, Type modelType, TextWriter textWriter, ExpandoObject viewBag = null);
    }
}