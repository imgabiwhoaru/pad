#pragma checksum "D:\UTM\Sem VII\PAD\Pad 3\PostMaker\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6a35712d6a60d219dffccebdaf6073cc987a006436f0951b8a2d905ddb62d8d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\UTM\Sem VII\PAD\Pad 3\PostMaker\Views\_ViewImports.cshtml"
using PostMaker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\UTM\Sem VII\PAD\Pad 3\PostMaker\Views\Home\Index.cshtml"
using PostMaker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6a35712d6a60d219dffccebdaf6073cc987a006436f0951b8a2d905ddb62d8d0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f47ed0180feb314b9cb6eb8185af8f3df86878fae90ce49a36fe62eecac0bb24", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PostViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\UTM\Sem VII\PAD\Pad 3\PostMaker\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <a href=\"/Home/CreatePost\" class=\"text-right\">\r\n        <h5>Create Your post</h5>\r\n    </a>\r\n\r\n");
#nullable restore
#line 13 "D:\UTM\Sem VII\PAD\Pad 3\PostMaker\Views\Home\Index.cshtml"
     if (Model.Any())
    {
        foreach (var post in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"post-container\">\r\n                <div><b>");
#nullable restore
#line 18 "D:\UTM\Sem VII\PAD\Pad 3\PostMaker\Views\Home\Index.cshtml"
                   Write(post.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> posted: </div>\r\n                <div class=\"post-content\"> ");
#nullable restore
#line 19 "D:\UTM\Sem VII\PAD\Pad 3\PostMaker\Views\Home\Index.cshtml"
                                      Write(Html.Raw(@post.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"text-right\">");
#nullable restore
#line 20 "D:\UTM\Sem VII\PAD\Pad 3\PostMaker\Views\Home\Index.cshtml"
                                   Write(post.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 22 "D:\UTM\Sem VII\PAD\Pad 3\PostMaker\Views\Home\Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>No posts in the last 24 hours to show.</h5>\r\n");
#nullable restore
#line 27 "D:\UTM\Sem VII\PAD\Pad 3\PostMaker\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PostViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
