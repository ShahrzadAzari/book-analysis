#pragma checksum "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69145e863c8d08a2e96ee0c32494a4b71080a904"
// <auto-generated/>
#pragma warning disable 1591
namespace Books.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\_Imports.razor"
using Books.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
using Books.core;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "style", "margin: auto;");
            __builder.AddMarkupContent(3, "\r\n    <div class=\"row\" style=\"margin-bottom: 100px;\"></div>\r\n    \r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-5");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                               SearchedBooks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                                             OnFindBook

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "class", "form-inline");
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "placeholder", "Book Name To Search..");
                __builder2.AddAttribute(25, "id", "searchName");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                                                                                                                  SearchedBooks.WordToSearch

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SearchedBooks.WordToSearch = __value, SearchedBooks.WordToSearch))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SearchedBooks.WordToSearch));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.AddMarkupContent(31, "<button type=\"submit\" class=\"btn btn-primary\">Find</button>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(32);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        <div class=\"col-7\"></div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n");
#nullable restore
#line 23 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
     if(SearchedBooks.WordToSearch != null)
    {
        if(now == condition.HasSearched && SearchedBooks.FoundBook.BookName == "")
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "            <div class=\"row\" style=\"margin-bottom: 100px;\"></div>\r\n            ");
            __builder.AddMarkupContent(38, @"<div class=""row"">
                <div class=""col-5"">
                    <div class=""card"" style=""width: 100%"">
                        <img src class=""card-img-top"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Sorry,Nothing Found!</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-7""></div>
            </div>
");
#nullable restore
#line 39 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
        }
        else
        {
            if(now == condition.HasSearched)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "                <div class=\"row\" style=\"margin-bottom: 100px;\"></div>\r\n                ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row");
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-5");
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "card");
            __builder.AddAttribute(48, "style", "width: 100%");
            __builder.AddMarkupContent(49, "\r\n                            ");
            __builder.OpenElement(50, "img");
            __builder.AddAttribute(51, "src", 
#nullable restore
#line 48 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                       SearchedBooks.FoundBook.PicPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(52, "class", "card-img-top");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "card-body");
            __builder.AddMarkupContent(56, "\r\n                                ");
            __builder.OpenElement(57, "h5");
            __builder.AddAttribute(58, "class", "card-title");
            __builder.AddContent(59, 
#nullable restore
#line 50 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                                        SearchedBooks.FoundBook.BookName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                                ");
            __builder.OpenElement(61, "p");
            __builder.AddAttribute(62, "class", "card-text");
            __builder.AddContent(63, 
#nullable restore
#line 51 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                                      SearchedBooks.ShowContent()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                ");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "type", "button");
            __builder.AddAttribute(67, "class", "btn btn-info");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                                                                     OnAnalyze

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(69, "Analyze");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 57 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
            }
            if(now == condition.HasAnalaized)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "                <div class=\"row\" style=\"margin-bottom: 100px;\"></div>\r\n                ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "row");
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-5");
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "card");
            __builder.AddAttribute(84, "style", "width: 100%");
            __builder.AddMarkupContent(85, "\r\n                            ");
            __builder.OpenElement(86, "img");
            __builder.AddAttribute(87, "src", 
#nullable restore
#line 64 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                       SearchedBooks.FoundBook.PicPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(88, "class", "card-img-top");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                            ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "card-body");
            __builder.AddMarkupContent(92, "\r\n                                ");
            __builder.OpenElement(93, "h5");
            __builder.AddAttribute(94, "class", "card-title");
            __builder.AddContent(95, 
#nullable restore
#line 66 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                                        SearchedBooks.FoundBook.BookName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                                ");
            __builder.OpenElement(97, "p");
            __builder.AddAttribute(98, "class", "card-text");
            __builder.AddContent(99, 
#nullable restore
#line 67 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                                      SearchedBooks.ShowContent()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                                ");
            __builder.OpenElement(101, "button");
            __builder.AddAttribute(102, "type", "button");
            __builder.AddAttribute(103, "class", "btn btn-info");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                                                                     OnAnalyze

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(105, "Analyze");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "col-7");
            __builder.AddMarkupContent(112, "\r\n\r\n                        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTabs>(113);
            __builder.AddAttribute(114, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(115, "\r\n                                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabsItem>(116);
                __builder2.AddAttribute(117, "Text", "Chart");
                __builder2.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(119, "\r\n                                    ");
                    __builder3.OpenComponent<Books.UI.Pages.ChartComponent>(120);
                    __builder3.AddAttribute(121, "ChartData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Books.core.DataItem[]>(
#nullable restore
#line 77 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                                                Datas.Chart

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(122, "ChartTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 77 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                                                                          SearchedBooks.FoundBook.BookName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(123, "\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(124, "\r\n\r\n                                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabsItem>(125);
                __builder2.AddAttribute(126, "Text", "Grid");
                __builder2.AddAttribute(127, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(128, "\r\n                                    ");
                    __builder3.OpenComponent<Books.UI.Pages.GridComponent>(129);
                    __builder3.AddAttribute(130, "RowTitles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 81 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                                               rowTitels

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(131, "Rows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[][]>(
#nullable restore
#line 81 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
                                                                                 rows

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(132, "\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(133, "\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(134, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n");
#nullable restore
#line 88 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
            }
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\git\AP98992\TA\AW16\BooksWebApp\Books.UI\Pages\Index.razor"
       
    condition now = condition.ToBeSearched;
    protected override void OnInitialized()
    {
        SearchedBooks = new BookSearch();
        PNWords = new PNWords();
    }
    AnalyzingBook Datas;
    private void OnFindBook()
    {
        now = condition.HasSearched;
        SearchedBooks.SearchBookName(SearchedBooks.WordToSearch);
        Analyze();
    }

    string[] rowTitels;
    string[][] rows;
    public async void Analyze()
    {
        Datas = new AnalyzingBook(SearchedBooks.FoundBook , PNWords);
        Task t1 = Datas.CountBookPNWords(SearchedBooks.FoundBook);
        Task t2 = Datas.EachTenTousond(SearchedBooks.FoundBook);
        await Task.WhenAll(new[]{t1,t2});
        Datas.PToNPercent = Math.Round((double)(Datas.BookPositiveWordsCount)/(double)(Datas.BookNegetiveWordsCount), 4);

        rowTitels = new[]{SearchedBooks.FoundBook.BookName};
        rows = new[]{
            new []{
                Datas.BookWordsCount.ToString(),
                Datas.BookPositiveWordsCount.ToString(),
                Datas.BookNegetiveWordsCount.ToString(),
                Datas.PToNPercent.ToString()
            }
        };
    }
    public void OnAnalyze()
    {
        now = condition.HasAnalaized;
    }

    enum condition {ToBeSearched , HasSearched , HasAnalaized}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PNWords PNWords { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BookSearch SearchedBooks { get; set; }
    }
}
#pragma warning restore 1591