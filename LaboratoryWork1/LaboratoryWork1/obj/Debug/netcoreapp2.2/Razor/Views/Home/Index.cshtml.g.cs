#pragma checksum "F:\Универ\7 семестр\ЦОС\COS\LaboratoryWork1\LaboratoryWork1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f71bc72a21c46874b899582e936ea777c3650632"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "F:\Универ\7 семестр\ЦОС\COS\LaboratoryWork1\LaboratoryWork1\Views\_ViewImports.cshtml"
using LaboratoryWork1;

#line default
#line hidden
#line 2 "F:\Универ\7 семестр\ЦОС\COS\LaboratoryWork1\LaboratoryWork1\Views\_ViewImports.cshtml"
using LaboratoryWork1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f71bc72a21c46874b899582e936ea777c3650632", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b9f2bc122a890669f64cee56f4cf163ea5eeaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LaboratoryWork1.ViewModels.Formula>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: flex; flex-direction: column;  align-items: flex-start;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Универ\7 семестр\ЦОС\COS\LaboratoryWork1\LaboratoryWork1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(90, 64, true);
            WriteLiteral("\r\n    <div class=\"text-center\" style=\"display: flex;\">\r\n        ");
            EndContext();
            BeginContext(154, 4564, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f71bc72a21c46874b899582e936ea777c36506325865", async() => {
                BeginContext(298, 4413, true);
                WriteLiteral(@"
            <div style=""display: none;"">
                <label>
                    M
                    <input id=""rangeM"" type=""range"" name=""m"" min=""0"" max=""1024"" step=""10"" value=""0"" onchange=""updateTextInputM(this.value)"" />
                    <input type=""text"" id=""textInputM"" value=""0"" onchange=""GetRequest()"" style=""width: 70px"" />
                </label>
                <label>Амплитуда 2<input type=""number"" step=""0.1"" name=""amplitude2"" value=""0.5"" id=""amplitude2"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                <label>Амплитуда 3<input type=""number"" step=""0.1"" name=""amplitude3"" value=""0.5"" id=""amplitude3"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                <label>Амплитуда 4<input type=""number"" step=""0.1"" name=""amplitude4"" value=""0.5"" id=""amplitude4"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                <label>Частота 1<input type=""number"" step=""0.1"" name=""frequency1"" value=""1"" id=""frequency1"" onchange=""GetRequest()"" style=""width:");
                WriteLiteral(@" 70px"" /></label>
                <label>Частота 2<input type=""number"" step=""0.1"" name=""frequency2"" value=""1"" id=""frequency2"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                <label>Частота 3<input type=""number"" step=""0.1"" name=""frequency3"" value=""1"" id=""frequency3"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                <label>Частота 4<input type=""number"" step=""0.1"" name=""frequency4"" value=""1"" id=""frequency4"" onchange=""GetRequest()"" style=""width: 70px"" /></label>

                <label><input type=""checkbox"" name=""amplitudem"" id=""amplitudem"" onchange=""GetRequest()"" />Амплитудная модуляция</label>
                <div style=""display: flex; flex-direction: column; align-items: flex-start;"">
                    <label><input type=""radio"" name=""radio"" value=""1"" checked onchange=""GetRequest()"" />Синусоида</label>
                    <label><input type=""radio"" name=""radio"" value=""5"" onchange=""GetRequest()"" />Пилообразный</label>
                    <label><input type");
                WriteLiteral(@"=""radio"" name=""radio"" value=""3"" onchange=""GetRequest()"" />Квадратичный</label>
                    <label><input type=""radio"" name=""radio"" value=""4"" onchange=""GetRequest()"" />Треугольный</label>
                    <label><input type=""radio"" name=""radio"" value=""6"" onchange=""GetRequest()"" />Синусоида + Квадратичный</label>
                    <label><input type=""radio"" name=""radio"" value=""7"" onchange=""GetRequest()"" />Квадратичный + Треугольный</label>
                    <label><input type=""radio"" name=""radio"" value=""8"" onchange=""GetRequest()"" />Треугольный + Пилообразный</label>
                    <label><input type=""radio"" name=""radio"" value=""9"" onchange=""GetRequest()"" />Пилообразный + Синусоида</label>
                </div>
            </div>
            <label>Амплитуда 1<input type=""number"" step=""0.1"" name=""amplitude"" value=""10"" id=""amplitude"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
            <label>Частота 1<input type=""number"" step=""0.1"" name=""frequency"" value=""10"" id=""freque");
                WriteLiteral(@"ncy"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
            <label>Начальная фаза<input type=""number"" step=""0.1"" name=""initialPhase"" value=""0"" id=""initialphase"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
            <label>
                N
                <input id=""range"" type=""range"" name=""n"" min=""256"" max=""2048"" step=""256"" value=""256"" onchange=""updateTextInput(this.value)"" />
                <input type=""text"" id=""textInput"" value=""256"" onchange=""GetRequest()"" style=""width: 70px"" />
            </label>
            <label><input type=""radio"" name=""radio"" value=""1"" checked onchange=""GetRequest()"" />Гармонический</label>
            <label><input type=""radio"" name=""radio"" value=""2"" onchange=""GetRequest()"" />Полигармонический</label>
            <label><input type=""radio"" name=""radio"" value=""3"" onchange=""GetRequest()"" />Полигармонический (быстрое Фурье)</label>
            <label><input type=""checkbox"" name=""lowfrequency"" id=""lowfrequency"" onchange=""GetRequest()"" />Низкочас");
                WriteLiteral(@"тотная фильтрация</label>
            <label><input type=""checkbox"" name=""highfrequency"" id=""highfrequency"" onchange=""GetRequest()"" />Высокочастотная фильтрация</label>
            <label><input type=""checkbox"" name=""linefrequency"" id=""linefrequency"" onchange=""GetRequest()"" />Полосовая фильтрация</label>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4718, 464, true);
            WriteLiteral(@"
        <div style=""display: flex; flex-direction: column;  align-items: flex-start;"">
            <div style=""width: 700px; height: 500px;"" id=""chart-container-1""></div>
            <div style=""width: 700px; height: 500px;"" id=""chart-container-2""></div>
            <div style=""width: 700px; height: 500px;"" id=""chart-container-3""></div>
            <div style=""width: 700px; height: 500px;"" id=""chart-container-4""></div>
        </div>
        
        ");
            EndContext();
            BeginContext(5182, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f71bc72a21c46874b899582e936ea777c365063213436", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5219, 9679, true);
            WriteLiteral(@"

        <script>
            var dataset = {
                label: '',
                backgroundColor: ""#FF0000"",
                borderColor: ""#FF0000"",
                borderWidth: 0,
                pointBackgroundColor: ""#FF0000"",
                pointBorderColor: ""#FF0000"",
                lineTension: 0,
                fill: false,
                data: []
            }
            var config1 = {
                type: 'line',
                data: {
                    labels: [],
                    datasets: [{
                label: '',
                backgroundColor: ""#FF0000"",
                borderColor: ""#FF0000"",
                borderWidth: 0,
                pointBackgroundColor: ""#FF0000"",
                pointBorderColor: ""#FF0000"",
                lineTension: 0,
                fill: false,
                data: []
            }]
                },
                options: {
                    elements: {
                        point: {
           ");
            WriteLiteral(@"                 radius: 0
                        }
                    },
                    responsive: true,
                    title: {
                        display: false,
                        text: 'Chart'
                    },
                    scales: {
                        xAxes: [{
                            display: true,
                        }],
                        yAxes: [{
                            ticks: {
                                stepSize: 1,
                            },
                            display: true,
                        }]
                    }
                }
            };
            var config2 = {
                type: 'line',
                data: {
                    labels: [],
                    datasets: [{
                label: '',
                backgroundColor: ""#FF0000"",
                borderColor: ""#FF0000"",
                borderWidth: 0,
                pointBackgroundColor: ""#FF0000"",
   ");
            WriteLiteral(@"             pointBorderColor: ""#FF0000"",
                lineTension: 0,
                fill: false,
                data: []
            }]
                },
                options: {
                    elements: {
                        point: {
                            radius: 0
                        }
                    },
                    responsive: true,
                    title: {
                        display: false,
                        text: 'Chart'
                    },
                    scales: {
                        xAxes: [{
                            display: true,
                        }],
                        yAxes: [{
                            ticks: {
                                stepSize: 1,
                            },
                            display: true,
                        }]
                    }
                }
            };
            var config3 = {
                type: 'line',
                da");
            WriteLiteral(@"ta: {
                    labels: [],
                    datasets: [{
                label: '',
                backgroundColor: ""#FF0000"",
                borderColor: ""#FF0000"",
                borderWidth: 0,
                pointBackgroundColor: ""#FF0000"",
                pointBorderColor: ""#FF0000"",
                lineTension: 0,
                fill: false,
                data: []
            }]
                },
                options: {
                    elements: {
                        point: {
                            radius: 0
                        }
                    },
                    responsive: true,
                    title: {
                        display: false,
                        text: 'Chart'
                    },
                    scales: {
                        xAxes: [{
                            display: true,
                        }],
                        yAxes: [{
                            ticks: {
            ");
            WriteLiteral(@"                    stepSize: 1,
                            },
                            display: true,
                        }]
                    }
                }
            };
            var config4 = {
                type: 'line',
                data: {
                    labels: [],
                    datasets: [{
                label: '',
                backgroundColor: ""#FF0000"",
                borderColor: ""#FF0000"",
                borderWidth: 0,
                pointBackgroundColor: ""#FF0000"",
                pointBorderColor: ""#FF0000"",
                lineTension: 0,
                fill: false,
                data: []
            }]
                },
                options: {
                    elements: {
                        point: {
                            radius: 0
                        }
                    },
                    responsive: true,
                    title: {
                        display: false,
             ");
            WriteLiteral(@"           text: 'Chart'
                    },
                    scales: {
                        xAxes: [{
                            display: true,
                        }],
                        yAxes: [{
                            ticks: {
                                stepSize: 1,
                            },
                            display: true,
                        }]
                    }
                }
            };
            window.onload = () => GetRequest();
            function updateTextInput(val) {
                document.getElementById('textInput').value = val;
                GetRequest();
            }

            function updateTextInputM(val) {
                document.getElementById('textInputM').value = val;
                GetRequest();
            }

            function ShowHideLine() {
                if ($('#line').prop('checked')) {
                    config.data.datasets[0].backgroundColor = ""#FF0000"";
                   ");
            WriteLiteral(@" config.data.datasets[0].borderColor = ""#FF0000"";
                    GetRequest();
                } else {
                    config.data.datasets[0].backgroundColor = ""#FFF"";
                    config.data.datasets[0].borderColor = ""#FFF"";
                    GetRequest();
                }
            }

            function DrawChart(config, number) {
                let chartContainer = document.getElementById('chart-container-' + number)
                chartContainer.innerHTML = '';
                let canvas = document.createElement('canvas');
                chartContainer.appendChild(canvas);
                canvas.id = 'myChart-' + number;
                canvas.width = '700px';
                canvas.height = '500px';
                var ctx = document.getElementById('myChart-' + number).getContext('2d');
                var myChart = new Chart(ctx, config);
            }

            function GetRequest() {
                $.get(""/Home/AxisX?n="" + $(""#textInput"").val(),
");
            WriteLiteral(@"                    function (data) {                       
                        config1.data.labels = data;
                        config2.data.labels = data;
                        config3.data.labels = data;
                        config4.data.labels = data;
                        $.get(""/Home/AxisY?amplitude="" + $(""#amplitude"").val() + ""&initialPhase="" + $(""#initialphase"").val() + ""&frequency="" + $(""#frequency"").val() + ""&n="" + $(""#textInput"").val() + ""&radiobutton=""+$(""#form input[type='radio']:checked"").val() + ""&lowfrequency="" + $('#lowfrequency').prop('checked') + ""&highfrequency="" + $('#highfrequency').prop('checked') + ""&linefrequency="" + $('#linefrequency').prop('checked'),
                            function (data) {
                                console.log(data);
                                //let config1 = Object.assign({}, config);
                                //let config2 = Object.assign({}, config);
                                //let config3 = Object.assign({},");
            WriteLiteral(@" config);
                                //let config4 = Object.assign({}, config);

                                //config1.data.datasets = [];
                                //config1.data.datasets.push(Object.assign({}, dataset));
                                config1.data.datasets[0].data = data.item1;

                                //config2.data.datasets = [];
                                //config2.data.datasets.push(Object.assign({}, dataset));
                                config2.data.datasets[0].data = data.item2;

                                //config3.data.datasets = [];
                                //config3.data.datasets.push(Object.assign({}, dataset));
                                config3.data.datasets[0].data = data.item3;

                                //config4.data.datasets = [];
                                //config4.data.datasets.push(Object.assign({}, dataset));
                                config4.data.datasets[0].data = data.item4;
     ");
            WriteLiteral(@"                           
                                DrawChart(config1, 1);
                                DrawChart(config2, 2);
                                DrawChart(config3, 3);
                                DrawChart(config4, 4);
                            }
                        );
                       
                        
                       
                    });

            }
        </script>

    </div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LaboratoryWork1.ViewModels.Formula> Html { get; private set; }
    }
}
#pragma warning restore 1591
