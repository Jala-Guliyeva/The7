#pragma checksum "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb91df00c9de89319cd930ec7aafcbae0150cc4b"
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
#line 1 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\_ViewImports.cshtml"
using The7Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\_ViewImports.cshtml"
using The7Backend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb91df00c9de89319cd930ec7aafcbae0150cc4b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bd4ba8af5aa7fa3392269c320336652ef08378c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <main>
        <section>
            <div class=""col-12"">
                <div class=""service-text"">
                    <h1>
                        OUR SERVICES
                    </h1>
                </div>
            </div>
         <div class=""container"">
            <div class=""row"">
                
");
#nullable restore
#line 18 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
          foreach (var item in Model.services)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"               <div class=""col-3"">
                <div class=""card"" style=""width: 18rem;"">
                    <div class=""icon"">
                        
                        <i class=""fa-solid  fa-heart""></i>
                    </div>
                    <div class=""card-body"">
                      <h5 class=""card-title"">");
#nullable restore
#line 27 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                      <p class=\"card-text\">");
#nullable restore
#line 28 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
                                      Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                      <a href=\"#\" class=\"btn readmore\">Read More</a>\r\n                    </div>\r\n                  </div>\r\n            </div>\n");
#nullable restore
#line 33 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            
            </div>
         </div>

        </section>

        

        <section>
          <div class=""slideshow-container"">

            <div class=""mySlides"">
              <q>The7 is an extraordinary, awesome Theme, I would recommend this Theme to anyone for their next project. Go ahead and download<br> it now!</q>
              <p class=""author"">- -David Bell</p>
            </div>
            
            <div class=""mySlides"">
              <q>The good times are for those who take action. The7 is a simple and easy to use template for creative people. Download this theme<br> and give it a try!</q>
              <p class=""author"">- -Eve Stinger</p>
            </div>
            
            <div class=""mySlides"">
              <q>Awesome theme! Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusamus incidunt possimus eveniet aperiam, minus<br> deleniti iure ipsa praesentium amet, labore voluptatum fugit earum, porro non sequi sint soluta reprehenderit ad?");
            WriteLiteral(@"</q>
              <p class=""author"">- Will Peters
              </p>
            </div>
            
            <a class=""prev"" onclick=""plusSlides(-1)"">❮</a>
            <a class=""next"" onclick=""plusSlides(1)"">❯</a>
              
            <div class=""dot-container"">
              <span class=""dot"" onclick=""currentSlide(1)""></span> 
              <span class=""dot"" onclick=""currentSlide(2)""></span> 
              <span class=""dot"" onclick=""currentSlide(3)""></span> 
            </div>
            </div>
          
            <script>
              var slideIndex = 1;
              showSlides(slideIndex);
              
              function plusSlides(n) {
                showSlides(slideIndex += n);
              }
              
              function currentSlide(n) {
                showSlides(slideIndex = n);
              }
              
              function showSlides(n) {
                var i;
                var slides = document.getElementsByClassName(""mySlides");
            WriteLiteral(@""");
                var dots = document.getElementsByClassName(""dot"");
                if (n > slides.length) {slideIndex = 1}    
                if (n < 1) {slideIndex = slides.length}
                for (i = 0; i < slides.length; i++) {
                    slides[i].style.display = ""none"";  
                }
                for (i = 0; i < dots.length; i++) {
                    dots[i].className = dots[i].className.replace("" active"", """");
                }
                slides[slideIndex-1].style.display = ""block"";  
                dots[slideIndex-1].className += "" active"";
              }
              </script>
              
        </section>

        <section>
          <div class=""col-12"">
            <div class=""service-text"">
                <h1>
                  OUR BLOG
                </h1>
            </div>
        </div>
       
        <div class=""container"">
          <div class=""row"">    
");
#nullable restore
#line 114 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
     foreach (var item in Model.blogs)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div class=\"col-6\">\r\n        <div class=\"card post\" style=\"width: 35rem;\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb91df00c9de89319cd930ec7aafcbae0150cc4b9591", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4180, "~/assets/images/post/", 4180, 21, true);
#nullable restore
#line 118 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4201, item.Image, 4201, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"post-body\">\r\n             <a href=\"#\">\r\n              <h5 class=\"post-title\">");
#nullable restore
#line 121 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n             </a>\r\n             <a href=\"#\">\r\n              <span>\r\n               ");
#nullable restore
#line 125 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
          Write(item.Time.ToString("dd,MMMM,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ·");
#nullable restore
#line 125 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
                                               Write(item.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              </span>\r\n             </a>\r\n\r\n              <p class=\"card-text\">");
#nullable restore
#line 129 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
                              Write(Html.Raw(item.Desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n              <a href=\"#\" class=\"btn post-more\">Read More</a>\r\n            </div>\r\n          </div>\r\n    </div>\n");
#nullable restore
#line 134 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    
      
          </div>
        </div>
        
        </section>

        <section>
          <div class=""col-12"">
            <div class=""service-text"">
                <h1>
                  PRICING TABLES
                </h1>
            </div>
        </div>
<div class=""container"">
  <div class=""row"">
    
               
    <div class=""col-3"">
      <div class=""card-price"" style=""width: 18rem;"">
        .
        <div class=""price-title"">
          <h3>ECONOMY</h3>
        </div>
          <div class=""price"">
              
           <div class=""price-text"">
            <span>$10/m</span>
           </div>
          </div>
          
          <div class=""price-desc"">
             <p> 1GB Storage</p>
             <p>2 Clients</p>
             <p>5 Active Projects</p>
             <p>Free Goodies</p>
             <p>24/7 Email support</p>
          </div>
          
          
            <a href=""#"" class=""btn purchase"">Purchase</a>
          </div>
");
            WriteLiteral(@"        
  </div>

  <div class=""col-3"">
    <div class=""card-price"" style=""width: 18rem;"">
      .
      <div class=""price-title"">
        <h3>ECONOMY</h3>
      </div>
        <div class=""price"">
            
         <div class=""price-text"">
          <span>$10/m</span>
         </div>
        </div>
        <div class=""price-desc"">
          <p> 5GB Storage</p>
          <p>10 Clients</p>
          <p>5 Active Projects</p>
          <p>Free Goodies</p>
          <p>24/7 Email support</p>
       </div>
       
          <a href=""#"" class=""btn purchase"">Purchase</a>
        </div>
      
</div>

<div class=""col-3"">
  <div class=""card-price"" style=""width: 18rem;"">
    .
    <div class=""price-title"">
      <h3>ECONOMY</h3>
    </div>
      <div class=""price"">
          
       <div class=""price-text"">
        <span>$10/m</span>
       </div>
      </div>
      
      <div class=""price-desc"">
        <p> 15GB Storage</p>
        <p>15 Clients</p>
        <p>15 Active");
            WriteLiteral(@" Projects</p>
        <p>Free Goodies</p>
        <p>24/7 Email support</p>
     </div>
     
        <a href=""#"" class=""btn purchase"">Purchase</a>
      </div>
    
</div>

<div class=""col-3"">
<div class=""card-price"" style=""width: 18rem;"">
  .
  <div class=""price-title"">
    <h3>ECONOMY</h3>
  </div>
    <div class=""price"">
        
     <div class=""price-text"">
      <span>$10/m</span>
     </div>
    </div>
    
    <div class=""price-desc"">
      <p> Unlimited Storage</p>
      <p>Unlimited Clients</p>
      <p>Unlimited Active Projects</p>
      <p>Free Goodies</p>
      <p>24/7 Email support</p>
   </div>
   
      <a href=""#"" class=""btn purchase"">Purchase</a>
    </div>
  
</div>
  </div>
</div>
        </section>


        <section>
          <div class=""col-12"">
            <div class=""service-text"">
                <h1>
                  OUR TEAM 
                </h1>
            </div>
        </div>
        <div class=""container"">
          <div cla");
            WriteLiteral("ss=\"row\">\r\n");
#nullable restore
#line 273 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
           foreach (var item in Model.teams)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"col-3\">\r\n              <div class=\"card\" style=\"width: 18rem;\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 7975, "\"", 8013, 2);
            WriteAttributeValue("", 7981, "./assets/images/team/", 7981, 21, true);
#nullable restore
#line 277 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 8002, item.Image, 8002, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                <div class=\"card-body\">\r\n                  <p class=\"team-text\">");
#nullable restore
#line 279 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
                                  Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <span>");
#nullable restore
#line 281 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
                     Write(item.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n              </div>\r\n            </div>\n");
#nullable restore
#line 285 "C:\Users\TOSHIBA\Desktop\The7Backend\The7Backend\Views\Home\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"           
          </div>
        </div>
        </section>

        <section>
          <div class=""slideshow-container"">

            <div class=""mySlides"">
             <div class=""icon"">
              
             </div>
              <p class=""author"">- -David Bell</p>
            </div>
            
            <div class=""mySlides"">
              <q>The good times are for those who take action. The7 is a simple and easy to use template for creative people. Download this theme<br> and give it a try!</q>
              <p class=""author"">- -Eve Stinger</p>
            </div>
            
            <div class=""mySlides"">
              <q>Awesome theme! Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusamus incidunt possimus eveniet aperiam, minus<br> deleniti iure ipsa praesentium amet, labore voluptatum fugit earum, porro non sequi sint soluta reprehenderit ad?</q>
              <p class=""author"">- Will Peters
              </p>
            </div>
            
 ");
            WriteLiteral(@"           <a class=""prev"" onclick=""plusSlides(-1)"">❮</a>
            <a class=""next"" onclick=""plusSlides(1)"">❯</a>
              
            <div class=""dot-container"">
              <span class=""dot"" onclick=""currentSlide(1)""></span> 
              <span class=""dot"" onclick=""currentSlide(2)""></span> 
              <span class=""dot"" onclick=""currentSlide(3)""></span> 
            </div>
            </div>
          
            <script>
              var slideIndex = 1;
              showSlides(slideIndex);
              
              function plusSlides(n) {
                showSlides(slideIndex += n);
              }
              
              function currentSlide(n) {
                showSlides(slideIndex = n);
              }
              
              function showSlides(n) {
                var i;
                var slides = document.getElementsByClassName(""mySlides"");
                var dots = document.getElementsByClassName(""dot"");
                if (n > slides.leng");
            WriteLiteral(@"th) {slideIndex = 1}    
                if (n < 1) {slideIndex = slides.length}
                for (i = 0; i < slides.length; i++) {
                    slides[i].style.display = ""none"";  
                }
                for (i = 0; i < dots.length; i++) {
                    dots[i].className = dots[i].className.replace("" active"", """");
                }
                slides[slideIndex-1].style.display = ""block"";  
                dots[slideIndex-1].className += "" active"";
              }
              </script>
              
        </section>

        <section>
          <div class=""col-12"">
            <div class=""contact-text"">
                <h1>
              CONTACT
                </h1>
            </div>
        </div>
        <div class=""container"">
          <div class=""row"">
            <div class=""col-6"">
                <div class=""container"">
                  <div class=""row"">
                    <h4>Talk to us
                     
                      <");
            WriteLiteral(@"/h4>
                      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores iusto fugit esse soluta quae debitis quibusdam harum voluptatem, maxime, aliquam sequi. Tempora ipsum magni unde velit corporis fuga, necessitatibus blanditiis.

                      </p>
                      <div>
                        <div class=""box-icon"">
                            <i class=""icon-location""></i>
                        </div>
                        <p>Address:</p>
                        <p>9983 City name, Street name, 232 Apartment C</p>
                    </div>
                    
                    <div>
                        <div class=""box-icon"">
                            <i class=""icon-clock""></i>
                        </div>
                        <p>Work Time:</p>
                        <p>Monday - Friday from 9am to 5pm</p>
                    </div>
                    
                    <div>
                        <div class=""box-icon"">
    ");
            WriteLiteral(@"                        <i class=""icon-phone""></i>
                        </div>
                        <p>Phone:</p>
                        <p>595 12 34 567</p>
                    </div>                                  
                </address>
            </div>
        </div>
                  </div>

                  <div class=""col-6"">
                    <div class=""content contact-form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb91df00c9de89319cd930ec7aafcbae0150cc4b22537", async() => {
                WriteLiteral(@"
                            <input type=""text"" class=""comment-name"" placeholder=""Name*"" required>
                            <input type=""email"" class=""comment-email"" placeholder=""Email*"" required>
                            <input type=""text"" class=""comment-subject"" placeholder=""Subject"">
                            <textarea class=""required comment-text"" placeholder=""Message..."" required></textarea>
                            <input type=""submit"" value=""Send Message"" class=""btn btn-success"">
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  \r\n                    </div>\r\n               \r\n               \r\n                 </div>\r\n                </div>\r\n            </div>\r\n\r\n        \r\n          \r\n          </div>\r\n        </div>\r\n        </section>\r\n    </main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
