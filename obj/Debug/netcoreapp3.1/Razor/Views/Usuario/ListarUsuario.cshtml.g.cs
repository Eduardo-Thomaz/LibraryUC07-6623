#pragma checksum "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\Usuario\ListarUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c49030a5771073194a3a31b89f761852f0b91303"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListarUsuario), @"mvc.1.0.view", @"/Views/Usuario/ListarUsuario.cshtml")]
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
#nullable restore
#line 1 "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c49030a5771073194a3a31b89f761852f0b91303", @"/Views/Usuario/ListarUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListarUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Usuários cadastrados no sistema</h1>\r\n\r\n\r\n<p class=\"text-danger\">");
#nullable restore
#line 5 "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                  Write(ViewData["mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table striped\">\r\n    <thead>\r\n        <tr>\r\n            <th scope =\"row\">Nome</th>\r\n            <th scope =\"row\">Login</th>\r\n            <th scope =\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 17 "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
         foreach (Usuario u in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 21 "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                 if(u.Tipo == Usuario.ADMIN) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Usuário administrativo</td>\r\n");
#nullable restore
#line 23 "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                }
                else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Usuário padrão</td>\r\n");
#nullable restore
#line 26 "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 703, "\"", 732, 2);
            WriteAttributeValue("", 710, "EditarUsuario?Id=", 710, 17, true);
#nullable restore
#line 28 "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
WriteAttributeValue("", 727, u.Id, 727, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 773, "\"", 803, 2);
            WriteAttributeValue("", 780, "ExcluirUsuario?Id=", 780, 18, true);
#nullable restore
#line 29 "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
WriteAttributeValue("", 798, u.Id, 798, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "D:\DesenvolvedorWeb\UC07\Projeto_UC_07_Eduardo-Thomaz\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a href=\"CadastrarUsuario\">Cadastrar novo usuário</a>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
