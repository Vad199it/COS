#pragma checksum "F:\Универ\7 семестр\ЦОС\COS\LaboratoryWork1\LaboratoryWork1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "894429f464c71ab8ff526722b736311452930a1e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"894429f464c71ab8ff526722b736311452930a1e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b9f2bc122a890669f64cee56f4cf163ea5eeaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LaboratoryWork1.ViewModels.Formula>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control custom-file-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ImageLoading", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: flex; flex-direction: column;  align-items: flex-start;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
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
            BeginContext(90, 88, true);
            WriteLiteral("\r\n    <div class=\"text-center\" style=\"display: flex; flex-direction: column;\">\r\n        ");
            EndContext();
            BeginContext(178, 754, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "894429f464c71ab8ff526722b736311452930a1e7539", async() => {
                BeginContext(298, 111, true);
                WriteLiteral("\r\n            <div class=\"form-group\" style=\"display: flex; flex-direction: row !important;\">\r\n                ");
                EndContext();
                BeginContext(409, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "894429f464c71ab8ff526722b736311452930a1e8037", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 10 "F:\Универ\7 семестр\ЦОС\COS\LaboratoryWork1\LaboratoryWork1\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Photo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(440, 114, true);
                WriteLiteral("\r\n                <div class=\"col-sm-10\">\r\n                    <div class=\"custom-file\">\r\n                        ");
                EndContext();
                BeginContext(554, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "894429f464c71ab8ff526722b736311452930a1e9769", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 13 "F:\Универ\7 семестр\ЦОС\COS\LaboratoryWork1\LaboratoryWork1\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Photo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(618, 307, true);
                WriteLiteral(@"
                        <label class=""custom-file-label"" style=""display: flex; justify-content: flex-start;"">Choose File...</label>
                    </div>
                </div>
                <button type=""submit"" name=""button"" class=""btn btn-primary"">Start</button>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(932, 53, true);
            WriteLiteral(" \r\n        <div style=\"display: flex;\">\r\n            ");
            EndContext();
            BeginContext(985, 5577, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "894429f464c71ab8ff526722b736311452930a1e13668", async() => {
                BeginContext(1129, 4935, true);
                WriteLiteral(@"


                <div style=""display: none;"">

                    <label>Амплитуда 2<input type=""number"" step=""0.1"" name=""amplitude2"" value=""0.5"" id=""amplitude2"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                    <label>Амплитуда 3<input type=""number"" step=""0.1"" name=""amplitude3"" value=""0.5"" id=""amplitude3"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                    <label>Амплитуда 4<input type=""number"" step=""0.1"" name=""amplitude4"" value=""0.5"" id=""amplitude4"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                    <label>Частота 1<input type=""number"" step=""0.1"" name=""frequency1"" value=""1"" id=""frequency1"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                    <label>Частота 2<input type=""number"" step=""0.1"" name=""frequency2"" value=""1"" id=""frequency2"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                    <label>Частота 3<input type=""number"" step=""0.1"" name=""frequency3"" value=""1"" id=""frequency3"" onchan");
                WriteLiteral(@"ge=""GetRequest()"" style=""width: 70px"" /></label>
                    <label>Частота 4<input type=""number"" step=""0.1"" name=""frequency4"" value=""1"" id=""frequency4"" onchange=""GetRequest()"" style=""width: 70px"" /></label>

                    <label><input type=""checkbox"" name=""amplitudem"" id=""amplitudem"" onchange=""GetRequest()"" />Амплитудная модуляция</label>
                    <div style=""display: flex; flex-direction: column; align-items: flex-start;"">
                        <label><input type=""radio"" name=""radio"" value=""1"" checked onchange=""GetRequest()"" />Синусоида</label>
                        <label><input type=""radio"" name=""radio"" value=""5"" onchange=""GetRequest()"" />Пилообразный</label>
                        <label><input type=""radio"" name=""radio"" value=""3"" onchange=""GetRequest()"" />Квадратичный</label>
                        <label><input type=""radio"" name=""radio"" value=""4"" onchange=""GetRequest()"" />Треугольный</label>
                        <label><input type=""radio"" name=""radio"" value=""6");
                WriteLiteral(@""" onchange=""GetRequest()"" />Синусоида + Квадратичный</label>
                        <label><input type=""radio"" name=""radio"" value=""7"" onchange=""GetRequest()"" />Квадратичный + Треугольный</label>
                        <label><input type=""radio"" name=""radio"" value=""8"" onchange=""GetRequest()"" />Треугольный + Пилообразный</label>
                        <label><input type=""radio"" name=""radio"" value=""9"" onchange=""GetRequest()"" />Пилообразный + Синусоида</label>
                        <label>Начальная фаза<input type=""number"" step=""0.1"" name=""initialPhase"" value=""0"" id=""initialphase"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                    </div>
                    <label>
                        Верхняя граница
                        <input id=""rangeHighEdge"" type=""range"" name=""rangehighedge"" min=""0"" max=""150"" step=""1"" value=""0"" onchange=""updateTextInputHighEdge(this.value)"" />
                        <input type=""text"" id=""textInputHighEdge"" value=""0"" onchange=""GetRequest()"" style");
                WriteLiteral(@"=""width: 70px"" />
                    </label>
                    <label>
                        Нижняя граница
                        <input id=""rangeLowEdge"" type=""range"" name=""rangelowedge"" min=""0"" max=""150"" step=""1"" value=""0"" onchange=""updateTextInputLowEdge(this.value)"" />
                        <input type=""text"" id=""textInputLowEdge"" value=""0"" onchange=""GetRequest()"" style=""width: 70px"" />
                    </label>
                    <label><input type=""radio"" name=""radio"" value=""1"" checked onchange=""GetRequest()"" />Гармонический</label>
                    <label><input type=""radio"" name=""radio"" value=""2"" onchange=""GetRequest()"" />Полигармонический</label>
                    <label><input type=""radio"" name=""radio"" value=""3"" onchange=""GetRequest()"" />Полигармонический (быстрое Фурье)</label>
                </div>

                <label>B1<input type=""number"" step=""0.1"" name=""b1"" value=""50"" id=""b1"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                <label>B2<i");
                WriteLiteral(@"nput type=""number"" step=""0.1"" name=""b2"" value=""1"" id=""b2"" onchange=""GetRequest()"" style=""width: 70px"" /></label>
                <label>
                    N
                    <input id=""range"" type=""range"" name=""n"" min=""256"" max=""2048"" step=""256"" value=""512"" onchange=""updateTextInput(this.value)"" />
                    <input type=""text"" id=""textInput"" value=""512"" onchange=""GetRequest()"" style=""width: 70px"" />
                </label>
                <label><input type=""checkbox"" name=""check1"" id=""check1"" checked onchange=""GetRequest()"" />Скользящее усреднение</label>
                <label><input type=""checkbox"" name=""check2"" id=""check2"" onchange=""GetRequest()"" />Парабола 4 степени</label>
                <label><input type=""checkbox"" name=""check3"" id=""check3"" onchange=""GetRequest()"" />Фильтрация медианой</label>
");
                EndContext();
                DefineSection("Scripts", async() => {
                    BeginContext(6098, 442, true);
                    WriteLiteral(@"
                    <script>
                        $(document).ready(function () {
                            $('.custom-file-input').on(""change"", function () {
                                var fileName = $(this).val().split(""\\"").pop();
                                $(this).next('.custom-file-label').html(fileName);
                            })
                        });
                    </script>
                ");
                    EndContext();
                }
                );
                BeginContext(6543, 12, true);
                WriteLiteral("            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6562, 672, true);
            WriteLiteral(@"
            <div style=""display: flex; flex-direction: column;  align-items: flex-start;"">
                <div style=""width: 700px; height: 500px;"" id=""chart-container-1""></div>
                <div style=""width: 700px; height: 500px;"" id=""chart-container-2""></div>
                <div style=""width: 700px; height: 500px;"" id=""chart-container-3""></div>
                <div style=""width: 700px; height: 500px;"" id=""chart-container-4""></div>
                <div style=""width: 700px; height: 500px;"" id=""chart-container-5""></div>
                <div style=""width: 700px; height: 500px;"" id=""chart-container-6""></div>
            </div>
        </div>
        ");
            EndContext();
            BeginContext(7234, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "894429f464c71ab8ff526722b736311452930a1e22797", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7271, 5084, true);
            WriteLiteral(@"

        <script>
            
            var config = {
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
                            radius: 0.5
                        }
                    },
                    responsive: true,
                    title: {
                        display: false,
                        text: 'Chart'
                    },
                    scales: {
                        xAxes: [{
                            display: true,");
            WriteLiteral(@"
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

            var config1 = JSON.parse(JSON.stringify(config));
            var config2 = JSON.parse(JSON.stringify(config));
            var config3 = JSON.parse(JSON.stringify(config));
            var config4 = JSON.parse(JSON.stringify(config));
            var config5 = JSON.parse(JSON.stringify(config));
            var config6 = JSON.parse(JSON.stringify(config));

            window.onload = () => GetRequest();
            function updateTextInput(val) {
                document.getElementById('textInput').value = val;
                GetRequest();
            }

            function updateTextInputHighEdge(val) {
                document.getElementById('textInputHighEdge').value = ");
            WriteLiteral(@"val;
                GetRequest();
            }

            function updateTextInputLowEdge(val) {
                document.getElementById('textInputLowEdge').value = val;
                GetRequest();
            }

            function ShowHideLine() {
                if ($('#line').prop('checked')) {
                    config.data.datasets[0].backgroundColor = ""#FF0000"";
                    config.data.datasets[0].borderColor = ""#FF0000"";
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
                chartContainer.appendCh");
            WriteLiteral(@"ild(canvas);
                canvas.id = 'myChart-' + number;
                canvas.width = '700px';
                canvas.height = '500px';
                var ctx = document.getElementById('myChart-' + number).getContext('2d');
                var myChart = new Chart(ctx, config);
            }

            function GetRequest() {
                $.get(""/Home/AxisX?n="" + $(""#textInput"").val(),
                    function (data) {
                        config1.data.labels = data;
                        config2.data.labels = data;
                        config3.data.labels = data;
                        config4.data.labels = data;
                        config5.data.labels = data;
                        config6.data.labels = data;
                        $.get(""/Home/AxisY?b1="" + $(""#b1"").val() + ""&b2="" + $(""#b2"").val() + ""&n="" + $(""#textInput"").val() + ""&check1="" + $('#check1').prop('checked') + ""&check2="" + $('#check2').prop('checked') + ""&check3="" + $('#check3').prop('checked'),");
            WriteLiteral(@"
                            function (data) {
                                config1.data.datasets[0].data = data.item1;
                                config2.data.datasets[0].data = data.item2;
                                config3.data.datasets[0].data = data.item3;
                                config4.data.datasets[0].data = data.item4;
                                config5.data.datasets[0].data = data.item5;
                                config6.data.datasets[0].data = data.item6;

                                DrawChart(config1, 1);
                                DrawChart(config2, 2);
                                DrawChart(config3, 3);
                                DrawChart(config4, 4);
                                DrawChart(config5, 5);
                                DrawChart(config6, 6);
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
