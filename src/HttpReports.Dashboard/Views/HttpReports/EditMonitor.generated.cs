﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HttpReports.Dashboard.Views
{
    using System;
    
    #line 3 "..\..\Views\HttpReports\EditMonitor.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class EditMonitor : HttpReports.Dashboard.Views.RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");




            
            #line 4 "..\..\Views\HttpReports\EditMonitor.cshtml"
  
    ViewData["Title"] = "EditMonitorRule";

    string Id = ViewData["Id"] as string; 

    var lang = ViewData["Language"] as HttpReports.Dashboard.Services.Localize;

    Layout = new HttpReports.Dashboard.Views.HttpReportsTemplate { Context = Context, ViewData = ViewData };



            
            #line default
            #line hidden
WriteLiteral(@"

<style type=""text/css"">

    .wizard-type1 .tab-pane {
        padding: 18px 6px;
    }

    .wizard-type1 ul.steps li.active a {
        border-left: 0;
        border-right: 0;
        border-bottom: 2px solid #67c2ef;
    }

    .wizard-type1 ul.steps li a {
        padding: 0;
        margin: 0 20px;
    }

    ");


WriteLiteral(@"@media screen and (min-width:1170px) {
        .title, .description, .email, .mobiles, .webhook {
            width: 75% !important;
        }
    }

    .tab-pane {
        margin-top: 12px;
        padding: 20px 15px;
        border-radius: 6px;
        border: 1px solid #ccc;
    }

    .service {
        margin-right:20px;
    }


</style>


<div class=""panel panel-default"">


    <div class=""panel-body  task_content"" style=""padding-left:30px;padding-right:30px;padding-top:30px;min-height:720px;padding-bottom:30px"">

        <ol class=""breadcrumb"">
            <li><a href=""/HttpReports/Monitor"">");


            
            #line 60 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                          Write(lang.Monitor_NavTitle);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><span href=\"#\">");


            
            #line 61 "..\..\Views\HttpReports\EditMonitor.cshtml"
                           Write(Id == "" || Id == "0" ? lang.Monitor_Add :lang.Monitor_Edit);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 61 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                         Write(lang.Task);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n        </ol>\r\n\r\n        <h3 style=\"margin-bottom:20px;\">");


            
            #line 64 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                    Write(Id == "" || Id == "0" ? lang.Monitor_Add : lang.Monitor_Edit);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 64 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                   Write(lang.Monitor_Task);

            
            #line default
            #line hidden
WriteLiteral(@"</h3>

        <div class=""row"">

            <div class=""panel panel-default"">
                <div class=""panel-body"" style=""padding:20px 35px"">

                    <div class=""row form-inline form"">

                        <div class=""row"" style=""margin-left:0;margin-right:0;margin-top:15px"">

                            <div class=""col-lg-9"">
                                <label style=""width:100px"" class=""form-label"">");


            
            #line 76 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                         Write(lang.Monitor_Title);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <input type=\"text\" class=\"form-control " +
"title\" placeholder=\"");


            
            #line 77 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                      Write(lang.Monitor_Title_Placeholder);

            
            #line default
            #line hidden
WriteLiteral(@""">
                            </div>

                        </div>

                        <div class=""row"" style=""margin-left:0;margin-right:0;margin-top:15px"">

                            <div class=""col-lg-9"">
                                <label style=""width:100px"" class=""form-label"">");


            
            #line 85 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                         Write(lang.Monitor_Description);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <input type=\"text\" class=\"form-control " +
"description\" placeholder=\"");


            
            #line 86 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                            Write(lang.Monitor_Desc_Placeholder);

            
            #line default
            #line hidden
WriteLiteral(@""">
                            </div>

                        </div>

                        <div class=""col-sm-12 form-inline form service-form"" style=""margin-left:0;margin-right:0;margin-top:15px;margin-bottom:15px"">

                            <div class=""col-sm-9"" style=""padding-left:0"">
                                <label style=""width:100px"" class=""form-label"">");


            
            #line 94 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                         Write(lang.Index_ServiceNode);

            
            #line default
            #line hidden
WriteLiteral(@"</label>
                                <select class=""selectpicker service"" data-live-search=""true"" data-style=""btn-primary"" data-width=""220px"" style=""margin-right:20px"">
                                    <option>ALL</option>
                                </select>
                                <select class=""selectpicker instance"" data-live-search=""true"" data-style=""btn-primary"" data-width=""220px"">
                                    <option>ALL</option>
                                </select>

                            </div> 

                        </div>

                        <div class=""row"" style=""margin-left:0;margin-right:0;margin-top:15px"">

                            <div class=""col-lg-9"">
                                <label style=""width:100px"" class=""form-label"">");


            
            #line 109 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                         Write(lang.Monitor_Email);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <input type=\"text\" class=\"form-control " +
"email\" placeholder=\"");


            
            #line 110 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                      Write(lang.Monitor_Email_Placeholder);

            
            #line default
            #line hidden
WriteLiteral(@""">
                            </div>

                        </div>

                        <div class=""row"" style=""margin-left:0;margin-right:0;margin-top:15px"">

                            <div class=""col-lg-9"">
                                <label style=""width:100px"" class=""form-label"">");


            
            #line 118 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                         Write(lang.Monitor_PushUrl);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <input type=\"text\" class=\"form-control " +
"webhook\" placeholder=\"");


            
            #line 119 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                        Write(lang.Monitor_Push_Placeholder);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n\r\n " +
"                       ");



WriteLiteral(@"

                        <div class=""row"" style=""margin-left:0;margin-right:0;margin-top:15px;display:none"">

                            <div class=""col-lg-9"">
                                <label style=""width:100px"" class=""form-label"">手机号列表</label>
                                <input type=""text"" value="""" class=""form-control mobiles"" placeholder=""告警接收手机号，支持多手机号 10086,10010..."">
                            </div>

                        </div>

                        <div class=""row"" style=""margin-left:0;margin-right:0;margin-top:15px;"">

                            <div class=""col-lg-9"">
                                <label style=""width:100px"" class=""form-label"">");


            
            #line 140 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                         Write(lang.Monitor_Frequency);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <select class=\"form-control interval\">\r" +
"\n                                    <option value=\"1\">");


            
            #line 142 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                 Write(lang.Monitor_Time1Min);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option value=\"3\">");


            
            #line 143 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                 Write(lang.Monitor_Time3Min);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option value=\"5\">");


            
            #line 144 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                 Write(lang.Monitor_Time5Min);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option value=\"10\">");


            
            #line 145 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                  Write(lang.Monitor_Time10Min);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option value=\"30\">");


            
            #line 146 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                  Write(lang.Monitor_Time30Min);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option value=\"60\" selected>");


            
            #line 147 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                           Write(lang.Monitor_Time1Hour);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option value=\"120\">");


            
            #line 148 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                   Write(lang.Monitor_Time2Hour);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option value=\"240\">");


            
            #line 149 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                   Write(lang.Monitor_Time4Hour);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option value=\"360\">");


            
            #line 150 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                   Write(lang.Monitor_Time6Hour);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option value=\"480\">");


            
            #line 151 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                   Write(lang.Monitor_Time8Hour);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option value=\"720\">");


            
            #line 152 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                   Write(lang.Monitor_Time12Hour);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option value=\"1440\">");


            
            #line 153 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                    Write(lang.Monitor_Time1Day);

            
            #line default
            #line hidden
WriteLiteral(@"</option>
                                </select>
                            </div>

                        </div>

                        <div class=""row"" style=""margin-left:0;margin-right:0;margin-top:15px"">

                            <div class=""col-lg-9"">
                                <label style=""width:100px"" class=""form-label"">");


            
            #line 162 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                         Write(lang.Monitor_State);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <input type=\"checkbox\" checked class=\"c" +
"heckbox\" data-on-text=\"");


            
            #line 163 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                         Write(lang.Monitor_CheckBox_Open);

            
            #line default
            #line hidden
WriteLiteral("\" data-handle-width=\"30\" data-off-text=\"");


            
            #line 163 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                                                                            Write(lang.Monitor_CheckBox_Close);

            
            #line default
            #line hidden
WriteLiteral(@""" data-size=""mini"" value="""" />
                            </div>

                        </div>


                    </div>

                    <div class=""clearfix"">
                    </div>


                    <div id=""wizard1"" class=""wizard-type1"" style=""margin-top:20px;"">

                        <div>

                            <ul class=""steps nav nav-pills"">
                                <li class=""active""><a href=""#tab11"" data-toggle=""tab""><span class=""badge badge-info""><i class=""fa fa-star""></i></span> ");


            
            #line 180 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                                                                  Write(lang.Monitor_Type_Timeout);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n                                <li class=\"\"><a href=\"#tab12\" data-tog" +
"gle=\"tab\"><span class=\"badge badge-info\"><i class=\"fa fa-credit-card\"></i></span" +
"> ");


            
            #line 181 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                                                                   Write(lang.Monitor_Type_RequestError);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n                                <li class=\"\"><a href=\"#tab13\" data-tog" +
"gle=\"tab\"><span class=\"badge badge-info\"><i class=\"fa fa-building\"></i></span> ");


            
            #line 182 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                                                                Write(lang.Monitor_Type_IP);

            
            #line default
            #line hidden
WriteLiteral(" </a></li>\r\n                                <li class=\"\"><a href=\"#tab14\" data-to" +
"ggle=\"tab\"><span class=\"badge badge-info\"><i class=\"fa fa-rocket\"></i></span> ");


            
            #line 183 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                                                              Write(lang.Monitor_Type_RequestCount);

            
            #line default
            #line hidden
WriteLiteral(@"</a></li>
                            </ul>


                        </div>

                        <div class=""tab-content"">

                            <div id=""tab11"" class=""tab-pane active"">

                                <div class=""row form-inline form"">

                                    <div class=""col-sm-12"">

                                        <div class=""col-lg-12"">

                                            <label class=""form-label"" style=""margin-right:10px"">");


            
            #line 199 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                           Write(lang.Monitor_State);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n\r\n                                            <input data-id=\"0\" type=\"" +
"checkbox\" class=\"checkbox\" data-on-text=\"");


            
            #line 201 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                         Write(lang.Monitor_CheckBox_Open);

            
            #line default
            #line hidden
WriteLiteral("\" data-handle-width=\"30\" data-off-text=\"");


            
            #line 201 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                                                                                            Write(lang.Monitor_CheckBox_Close);

            
            #line default
            #line hidden
WriteLiteral(@""" data-size=""mini"" value="""" />

                                        </div>

                                    </div>


                                    <div class=""col-sm-12"" style=""margin-top:6px"">

                                        <div class=""col-sm-3"">
                                            <label class=""form-label"" style=""width:80px"">");


            
            #line 211 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                    Write(lang.Monitor_Timeout);

            
            #line default
            #line hidden
WriteLiteral(@"</label>
                                            <input type=""text"" class=""form-control RtTime"" placeholder="""">
                                        </div>

                                        <div class=""col-sm-3"" style=""padding:0"">
                                            <label class=""form-label"">");


            
            #line 216 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                 Write(lang.Monitor_Timeout_Percentage);

            
            #line default
            #line hidden
WriteLiteral(@"</label>
                                            <input type=""text"" value=""0.00%"" class=""form-control RtPercent"" placeholder=""0.01% 15% ... "">
                                        </div>

                                    </div>

                                    <div class=""col-sm-12"" style=""margin-top:20px;"">

                                        <div style=""margin-left:12px; margin-right:12px;margin-bottom:0"" class=""alert alert-info"" role=""alert"">

                                            <p><b>");


            
            #line 226 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                             Write(lang.Monitor_Type_Timeout);

            
            #line default
            #line hidden
WriteLiteral("</b>：");


            
            #line 226 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                            Write(lang.Monitor_Timeout_Description);

            
            #line default
            #line hidden
WriteLiteral(" </p>\r\n\r\n                                            <p>");


            
            #line 228 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                          Write(lang.Monitor_Timeout_Info);

            
            #line default
            #line hidden
WriteLiteral(@"</p>

                                        </div>

                                    </div>

                                </div>

                            </div>

                            <div class=""tab-pane"" id=""tab12"">

                                <div class=""row form-inline form"">

                                    <div class=""col-sm-12"">

                                        <div class=""col-lg-12"">

                                            <label class=""form-label"" style=""margin-right:10px"">");


            
            #line 246 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                           Write(lang.Monitor_State);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n\r\n                                            <input type=\"checkbox\" cl" +
"ass=\"checkbox\" data-on-text=\"");


            
            #line 248 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                             Write(lang.Monitor_CheckBox_Open);

            
            #line default
            #line hidden
WriteLiteral("\" data-handle-width=\"30\" data-off-text=\"");


            
            #line 248 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                                                                                Write(lang.Monitor_CheckBox_Close);

            
            #line default
            #line hidden
WriteLiteral(@""" data-size=""mini"" value="""" />

                                        </div>

                                    </div>

                                    <div class=""col-sm-12"" style=""margin-top:6px"">

                                        <div class=""col-sm-3"">
                                            <label class=""form-label"">");


            
            #line 257 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                 Write(lang.Monitor_HttpStatusCode);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                            <input type=\"text\" class=\"f" +
"orm-control HttpCodes\" placeholder=\"");


            
            #line 258 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                      Write(lang.Monitor_HttpStatusCode_Desc);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                        </div>\r\n\r\n                           " +
"             <div class=\"col-sm-3\">\r\n                                           " +
" <label class=\"form-label\">");


            
            #line 262 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                 Write(lang.Monitor_Timeout_Percentage);

            
            #line default
            #line hidden
WriteLiteral(@"</label>
                                            <input type=""text"" value=""0.00%"" class=""form-control HttpPercent"" placeholder="" 0.01% 15% ... "">
                                        </div>

                                    </div>

                                    <div class=""col-sm-12"" style=""margin-top:20px;"">

                                        <div style=""margin-left:12px;margin-right:12px;margin-bottom:0"" class=""alert alert-info"" role=""alert"">

                                            <p><b>");


            
            #line 272 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                             Write(lang.Monitor_Type_RequestError);

            
            #line default
            #line hidden
WriteLiteral("</b>：");


            
            #line 272 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                 Write(lang.Monitor_Type_RequestError_Desc);

            
            #line default
            #line hidden
WriteLiteral(" </p>\r\n\r\n                                            <p>");


            
            #line 274 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                          Write(lang.Monitor_Type_RequestError_Info);

            
            #line default
            #line hidden
WriteLiteral(@"</p>

                                        </div>

                                    </div>

                                </div>

                            </div>

                            <div class=""tab-pane"" id=""tab13"">

                                <div class=""row form-inline form"">

                                    <div class=""col-sm-12"">

                                        <div class=""col-lg-12"">

                                            <label class=""form-label"" style=""margin-right:10px"">");


            
            #line 292 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                           Write(lang.Monitor_State);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n\r\n                                            <input type=\"checkbox\" cl" +
"ass=\"checkbox\" data-on-text=\"");


            
            #line 294 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                             Write(lang.Monitor_CheckBox_Open);

            
            #line default
            #line hidden
WriteLiteral("\" data-handle-width=\"30\" data-off-text=\"");


            
            #line 294 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                                                                                Write(lang.Monitor_CheckBox_Close);

            
            #line default
            #line hidden
WriteLiteral(@""" data-size=""mini"" value="""" />

                                        </div>

                                    </div>


                                    <div class=""col-sm-12"" style=""margin-top:6px"">

                                        <div class=""col-sm-3"">
                                            <label class=""form-label"">");


            
            #line 304 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                 Write(lang.Monitor_IPWhiteList);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                            <input type=\"text\" class=\"f" +
"orm-control IPWhiteList\" placeholder=\"");


            
            #line 305 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                        Write(lang.Monitor_IPWhiteList_Placeholder);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                        </div>\r\n\r\n                           " +
"             <div class=\"col-sm-3\">\r\n                                           " +
" <label class=\"form-label\">");


            
            #line 309 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                 Write(lang.Monitor_Timeout_Percentage);

            
            #line default
            #line hidden
WriteLiteral(@"</label>
                                            <input value=""0.00%"" type=""text"" class=""form-control IPPercent"" placeholder=""0.01% 15% ... "">
                                        </div>

                                    </div>

                                    <div class=""col-sm-12"" style=""margin-top:20px;"">

                                        <div style=""margin-left:12px;margin-right:12px;margin-bottom:0"" class=""alert alert-info"" role=""alert"">

                                            <p><b>");


            
            #line 319 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                             Write(lang.Monitor_Type_IP);

            
            #line default
            #line hidden
WriteLiteral("</b>：");


            
            #line 319 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                       Write(lang.Monitor_IP_Desc);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\r\n                                            <p> ");


            
            #line 321 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                           Write(lang.Monitor_IP_Info);

            
            #line default
            #line hidden
WriteLiteral(@" </p>

                                        </div>

                                    </div>

                                </div>


                            </div>

                            <div class=""tab-pane"" id=""tab14"">

                                <div class=""row form-inline form"">

                                    <div class=""col-sm-12"">

                                        <div class=""col-lg-12"">

                                            <label class=""form-label"" style=""margin-right:10px"">");


            
            #line 340 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                           Write(lang.Monitor_State);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n\r\n                                            <input type=\"checkbox\" cl" +
"ass=\"checkbox\" data-on-text=\"");


            
            #line 342 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                             Write(lang.Monitor_CheckBox_Open);

            
            #line default
            #line hidden
WriteLiteral("\" data-handle-width=\"30\" data-off-text=\"");


            
            #line 342 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                                                                                Write(lang.Monitor_CheckBox_Close);

            
            #line default
            #line hidden
WriteLiteral(@""" data-size=""mini"" value="""" />

                                        </div>

                                    </div>

                                    <div class=""col-sm-12"" style=""margin-top:6px"">

                                        <div class=""col-sm-3"">
                                            <label class=""form-label"">");


            
            #line 351 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                 Write(lang.Monitor_Max_Request);

            
            #line default
            #line hidden
WriteLiteral(@"</label>
                                            <input type=""text"" class=""form-control RequestCount"">
                                        </div>

                                    </div>

                                    <div class=""col-sm-12"" style=""margin-top:20px;"">

                                        <div style=""margin-left:12px;margin-right:12px;margin-bottom:0"" class=""alert alert-info"" role=""alert"">

                                            <p><b>");


            
            #line 361 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                             Write(lang.Monitor_Type_RequestCount);

            
            #line default
            #line hidden
WriteLiteral("</b>：");


            
            #line 361 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                 Write(lang.Monitor_Type_RequestCount_Desc);

            
            #line default
            #line hidden
WriteLiteral(" </p>\r\n\r\n                                            <p> ");


            
            #line 363 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                           Write(lang.Monitor_Type_RequestCount_Info);

            
            #line default
            #line hidden
WriteLiteral(@" </p>

                                        </div>

                                    </div>
                                </div>


                            </div>

                        </div>

                        <input type=""hidden"" class=""id"" value=""");


            
            #line 375 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                           Write(Id);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\r\n                        <div class=\"actions\" style=\"margin-top:15px;margin-" +
"bottom:8px;\">\r\n                            <button onclick=\"saveMonitorJob()\" ty" +
"pe=\"button\" class=\"btn btn-info button-previous\" style=\"width:80px\"> ");


            
            #line 378 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                                                 Write(lang.Save);

            
            #line default
            #line hidden
WriteLiteral(" </button>\r\n\r\n                            <a href=\"/HttpReports/Monitor\" type=\"bu" +
"tton\" class=\"btn btn-info button-previous\" style=\"width:120px;margin-left:20px\">" +
" ");


            
            #line 380 "..\..\Views\HttpReports\EditMonitor.cshtml"
                                                                                                                                               Write(lang.Back);

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n\r\n                        </div>\r\n\r\n\r\n                    </div>\r\n\r\n      " +
"          </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n" +
"\r\n<script src=\"/HttpReportsStaticFiles/Content/page/edit_monitor.js?ver=1.0.5\"><" +
"/script>\r\n\r\n\r\n");


        }
    }
}
#pragma warning restore 1591