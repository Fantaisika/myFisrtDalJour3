#pragma checksum "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myFirstDAL\myFirstDAL\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96c21fa65df7dd18c1e3a2ee528141f17fb182d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96c21fa65df7dd18c1e3a2ee528141f17fb182d6", @"/Views/Home/Login.cshtml")]
    #nullable restore
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myFirstDAL\myFirstDAL\Views\Home\Login.cshtml"
 using (Html.BeginForm()) // la notion du helpers pour generer du html et appuyant sur connecter , il declenche la meme requete post avec lurl de la page
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n        <legend>Connexion : </legend>\r\n        ");
#nullable restore
#line 10 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myFirstDAL\myFirstDAL\Views\Home\Login.cshtml"
   Write(Html.Label("Login : "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myFirstDAL\myFirstDAL\Views\Home\Login.cshtml"
   Write(Html.TextBox("Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 13 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myFirstDAL\myFirstDAL\Views\Home\Login.cshtml"
   Write(Html.Label("Mot de passe : "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myFirstDAL\myFirstDAL\Views\Home\Login.cshtml"
   Write(Html.TextBox("mdp"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <input type=\"submit\" value=\"Se Connecter...\" /> \r\n    </fieldset>\r\n");
#nullable restore
#line 18 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myFirstDAL\myFirstDAL\Views\Home\Login.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591