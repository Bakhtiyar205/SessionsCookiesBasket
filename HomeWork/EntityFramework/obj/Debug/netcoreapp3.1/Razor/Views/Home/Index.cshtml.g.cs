#pragma checksum "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a45834d639ed8339585c2495e5671c1231a66d3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\_ViewImports.cshtml"
using EntityFramework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\_ViewImports.cshtml"
using EntityFramework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\_ViewImports.cshtml"
using EntityFramework.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a45834d639ed8339585c2495e5671c1231a66d3c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a15e736fe65f9e795c38e4297cadae2c56c9fe8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProductsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- MAIN START -->\r\n\r\n<main>\r\n\r\n    <!-- SLIDER START -->\r\n\r\n    <section id=\"slider\">\r\n        <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 10 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
             foreach (var item in Model.Sliders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div> <img");
            BeginWriteAttribute("src", " src=\"", 238, "\"", 259, 2);
            WriteAttributeValue("", 244, "img/", 244, 4, true);
#nullable restore
#line 12 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
WriteAttributeValue("", 248, item.Image, 248, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 260, "\"", 266, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n");
#nullable restore
#line 13 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"container context pl-lg-5 ml-lg-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-5\">\r\n                    <div class=\"text\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.Detail.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p class=\"text-black-50 d-none d-sm-block\">\r\n                            ");
#nullable restore
#line 21 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                       Write(Model.Detail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"img\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 781, "\"", 810, 2);
            WriteAttributeValue("", 787, "img/", 787, 4, true);
#nullable restore
#line 25 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
WriteAttributeValue("", 791, Model.Detail.Image, 791, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 811, "\"", 817, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SLIDER END -->
    <!-- PRODUCTS START -->

    <section id=""products"">
        <div class=""container"">
            <div class=""row pt-5"">
                <div class=""col-12 d-flex justify-content-between"">
                    <ul class=""category-mobile d-md-none list-unstyled"">
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1284, "\"", 1291, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                            <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1522, "\"", 1529, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1597, "\"", 1604, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"popular\">Popular</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1680, "\"", 1687, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"winter\">Winter</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1761, "\"", 1768, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"various\">Various</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1844, "\"", 1851, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"exotic\">Exotic</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1925, "\"", 1932, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"green\">Greens</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2005, "\"", 2012, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"cactuse\">Cactuses</a></li>\r\n                            </ul>\r\n                        </li>\r\n                    </ul>\r\n                    <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2248, "\"", 2255, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 56 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                         foreach (var ct in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2409, "\"", 2416, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 58 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                                               Write(ct.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 58 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                                                                   Write(ct.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 59 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2628, "\"", 2635, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a45834d639ed8339585c2495e5671c1231a66d3c11426", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 71 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Products;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </section>

    <!-- PRODUCTS END -->
    <!-- ABOUT START -->

    <section id=""about"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-lg-6"">
                    <div class=""img"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 3251, "\"", 3280, 2);
            WriteAttributeValue("", 3257, "img/", 3257, 4, true);
#nullable restore
#line 84 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
WriteAttributeValue("", 3261, Model.Abouts.Image, 3261, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 3299, "\"", 3305, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                            <i class=""fas fa-play fa-lg""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                        <h1>");
#nullable restore
#line 92 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                       Write(Html.Raw(Model.Abouts.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                        <p class=""py-3"">
                            Where flowers are our inspiration to create lasting memories. Whatever the
                            occasion...
                        </p>
                        <ul class=""list-unstyled"">
");
#nullable restore
#line 98 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                             foreach (var item in Model.Abouts.Advantages)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"mt-3\">\r\n                                    <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 4265, "\"", 4271, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 101 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                                                                                     Write(item.Advantage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 103 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- ABOUT END -->
    <!-- EXPERTS START -->

    <section id=""experts"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        <h1>");
#nullable restore
#line 120 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                       Write(Model.ExpertSection.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"text-black-50\">\r\n                            ");
#nullable restore
#line 122 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                       Write(Model.ExpertSection.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row pb-5\">\r\n");
#nullable restore
#line 128 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                 foreach (var item in Model.Experts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-3\">\r\n                        <div class=\"item text-center\">\r\n                            <div class=\"img\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 5322, "\"", 5391, 2);
            WriteAttributeValue("", 5328, "img/", 5328, 4, true);
#nullable restore
#line 133 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
WriteAttributeValue("", 5332, item.Image.Where(i=>i.IsMain==true).FirstOrDefault().Image, 5332, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 5425, "\"", 5431, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"text mt-3\">\r\n                                <h6>");
#nullable restore
#line 136 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"text-black-50\">");
#nullable restore
#line 137 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                                                    Write(item.Duty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 141 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
            </div>
        </div>
    </section>

    <!-- EXPERTS END -->
    <!-- SUBSCRIBE START -->

    <section id=""subscribe"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-12"">
                    <div class=""content text-center py-5"">
                        <h3>Join The Colorful Bunch!</h3>
                        <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                            <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                            <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SUBSCRIBE END -->
    <!-- BLOG START -->");
            WriteLiteral(@"

    <section id=""blog"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        <h1>From our Blog</h1>
                        <p class=""text-black-50"">
                            A perfect blend of creativity, energy, communication, happiness and
                            love. Let us arrange
                            a smile for you.
                        </p>
                    </div>
                </div>
            </div>
            <div class=""row pb-5"">
");
#nullable restore
#line 188 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                 foreach (var item in Model.Blogs)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-4\">\r\n                        <div class=\"item\">\r\n                            <div class=\"img position-relative\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 7690, "\"", 7711, 2);
            WriteAttributeValue("", 7696, "img/", 7696, 4, true);
#nullable restore
#line 194 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
WriteAttributeValue("", 7700, item.Image, 7700, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 7730, "\"", 7736, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                                    <span>");
#nullable restore
#line 196 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                                     Write(item.DateTime.ToString("yyyy.MM.dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"text mt-3 text-center px-5\">\r\n                                <h5>");
#nullable restore
#line 200 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                               Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-black-50\">\r\n                                    ");
#nullable restore
#line 202 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                               Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 207 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </section>

    <!-- BLOG END -->
    <!-- SAY START -->

    <section id=""say"">
        <div class=""container"">
            <div class=""row py-5 justify-content-center"">
                <div class=""col-md-8 col-xl-6"">
                    <div class=""owl-carousel say"">
");
#nullable restore
#line 221 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                         foreach (var item in Model.ExpertsThoughts)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <div class=\"item text-center\">\r\n                                    <div class=\"img d-flex justify-content-center\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 9035, "\"", 9104, 2);
            WriteAttributeValue("", 9041, "img/", 9041, 4, true);
#nullable restore
#line 227 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
WriteAttributeValue("", 9045, item.Image.Where(i=>i.IsMain==true).FirstOrDefault().Image, 9045, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 9105, "\"", 9111, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"text text-muted pt-3 pb-5\">\r\n                                        <i>\r\n                                            ");
#nullable restore
#line 231 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                                       Write(item.Thought);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </i>\r\n                                    </div>\r\n                                    <div class=\"author\">\r\n                                        <h6>");
#nullable restore
#line 235 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"text-black-50\">Florist</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 240 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <!-- SAY END -->\r\n    <!-- INSTAGRAM START -->\r\n\r\n    <section id=\"instagram\">\r\n        <div class=\"owl-carousel instagram\">\r\n");
#nullable restore
#line 252 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
             foreach (var item in Model.Instagrams)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><img");
            BeginWriteAttribute("src", " src=\"", 10103, "\"", 10124, 2);
            WriteAttributeValue("", 10109, "img/", 10109, 4, true);
#nullable restore
#line 254 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
WriteAttributeValue("", 10113, item.Image, 10113, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 10143, "\"", 10149, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 255 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson6CookiesSessionBasket\HomeWork\EntityFramework\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n            #FIORELLO\r\n        </div>\r\n    </section>\r\n\r\n    <!-- INSTAGRAM END -->\r\n\r\n</main>\r\n\r\n<!-- MAIN END -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
