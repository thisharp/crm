#pragma checksum "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0005e9026c01796ec8d46aaead673c3c39d2192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EnterCustom_WorkPlanIndex), @"mvc.1.0.view", @"/Views/EnterCustom/WorkPlanIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EnterCustom/WorkPlanIndex.cshtml", typeof(AspNetCore.Views_EnterCustom_WorkPlanIndex))]
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
#line 1 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
using lsc.Model;

#line default
#line hidden
#line 2 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
using lsc.Model.Enume;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0005e9026c01796ec8d46aaead673c3c39d2192", @"/Views/EnterCustom/WorkPlanIndex.cshtml")]
    public class Views_EnterCustom_WorkPlanIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WorkPlan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
  
    ViewData["Title"] = "工作计划";
    Layout = "~/Pages/_Layout.cshtml";
    List<EnterCustomer> elist = ViewBag.elist;

#line default
#line hidden
            BeginContext(193, 392, true);
            WriteLiteral(@"
<blockquote class=""layui-elem-quote"">
    工作计划
    <a class=""layui-btn layui-btn-normal"" href=""javascript:;"" onclick=""addplan('0')"">添加工作计划</a>
</blockquote>
<table class=""layui-table"">
    <thead>
        <tr>
            <th>计划内容</th>
            <th>客户名称</th>
            <th>计划时间</th>
            <th>状态</th>
            <th>操作</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 25 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
         if (Model!=null)
        {
            foreach (var info in Model)
            {
                string name = string.Empty;
                int id = 0;
                if (elist!=null)
                {
                    var e = elist.FirstOrDefault(x=>x.ID==info.EnterCustID);
                    if (e!=null)
                    {
                        name = e.EnterName;
                        id = e.ID;
                     }
                }

#line default
#line hidden
            BeginContext(1065, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1112, 16, false);
#line 41 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
                   Write(info.PlanContent);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 33, true);
            WriteLiteral("</td>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1161, "\"", 1219, 2);
            WriteAttributeValue("", 1168, "/EnterCustom/EnterCustomInfo?id=", 1168, 32, true);
#line 42 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
WriteAttributeValue("", 1200, info.EnterCustID, 1200, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1220, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1222, 4, false);
#line 42 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
                                                                                 Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(1226, 36, true);
            WriteLiteral("</a> </td>\r\n                    <td>");
            EndContext();
            BeginContext(1263, 36, false);
#line 43 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
                   Write(info.PlanTime.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 30, true);
            WriteLiteral("</td>\r\n                    <td");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1329, "\"", 1408, 1);
#line 44 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
WriteAttributeValue("", 1337, info.WorkPlanState== WorkPlanStateEnum.NoFinish ? "color:#F581B1":"", 1337, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1409, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1411, 29, false);
#line 44 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
                                                                                                   Write(info.WorkPlanState.TryToStr());

#line default
#line hidden
            EndContext();
            BeginContext(1440, 88, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <div class=\"layui-btn-group\">\r\n");
            EndContext();
#line 47 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
                             if (info.EnterCustID > 0)
                            {

#line default
#line hidden
            BeginContext(1615, 88, true);
            WriteLiteral("                                <a href=\"javascript:;\" class=\"layui-btn layui-btn-small\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1703, "\"", 1750, 3);
            WriteAttributeValue("", 1713, "showcontroller(\'", 1713, 16, true);
#line 49 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
WriteAttributeValue("", 1729, info.EnterCustID, 1729, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1748, "\')", 1748, 2, true);
            EndWriteAttribute();
            BeginContext(1751, 81, true);
            WriteLiteral(">查看联系方式</a>\r\n                                <a class=\"layui-btn layui-btn-small\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1832, "\"", 1874, 3);
            WriteAttributeValue("", 1842, "updatephase(\'", 1842, 13, true);
#line 50 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
WriteAttributeValue("", 1855, info.EnterCustID, 1855, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 1872, "\')", 1872, 2, true);
            EndWriteAttribute();
            BeginContext(1875, 81, true);
            WriteLiteral(">添加联系记录</a>\r\n                                <a class=\"layui-btn layui-btn-small\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1956, "\"", 1994, 3);
            WriteAttributeValue("", 1966, "addplan(\'", 1966, 9, true);
#line 51 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
WriteAttributeValue("", 1975, info.EnterCustID, 1975, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 1992, "\')", 1992, 2, true);
            EndWriteAttribute();
            BeginContext(1995, 11, true);
            WriteLiteral(">预约下次</a>\r\n");
            EndContext();
#line 52 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
                            }

#line default
#line hidden
            BeginContext(2037, 84, true);
            WriteLiteral("                            <a href=\"javascript:;\" class=\"layui-btn layui-btn-small\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2121, "\"", 2151, 3);
            WriteAttributeValue("", 2131, "finish(\'", 2131, 8, true);
#line 53 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
WriteAttributeValue("", 2139, info.ID, 2139, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 2149, "\')", 2149, 2, true);
            EndWriteAttribute();
            BeginContext(2152, 110, true);
            WriteLiteral(">完成</a>\r\n                            <a href=\"javascript:;\" class=\"layui-btn layui-btn-danger layui-btn-small\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2262, "\"", 2289, 3);
            WriteAttributeValue("", 2272, "del(\'", 2272, 5, true);
#line 54 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
WriteAttributeValue("", 2277, info.ID, 2277, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 2287, "\')", 2287, 2, true);
            EndWriteAttribute();
            BeginContext(2290, 125, true);
            WriteLiteral("><i class=\"layui-icon\">&#xe640;</i>删除</a>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 58 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
             }
        }

#line default
#line hidden
            BeginContext(2442, 47, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div id=\"page\"></div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2506, 300, true);
                WriteLiteral(@"
<script>
    var layer
    layui.use(['table', 'element', 'layer','laypage'], function(){
        var table = layui.table;
        layer = layui.layer
        laypage = layui.laypage
        //分页
            laypage.render({
                elem: 'page' //分页容器的id
                , count: ");
                EndContext();
                BeginContext(2808, 13, false);
#line 73 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
                     Write(ViewBag.count);

#line default
#line hidden
                EndContext();
                BeginContext(2822, 141, true);
                WriteLiteral(" //总页数\r\n                ,limit:30\r\n                , skin: \'#1E9FFF\' //自定义选中色值\r\n                //,skip: true //开启跳页\r\n                ,curr: ");
                EndContext();
                BeginContext(2965, 17, false);
#line 77 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\WorkPlanIndex.cshtml"
                   Write(ViewBag.pageIndex);

#line default
#line hidden
                EndContext();
                BeginContext(2983, 1740, true);
                WriteLiteral(@" //获取起始页
                , jump: function (obj, first) {
                    console.log(obj)
                    if (!first) {
                        window.location = '/EnterCustom/WorkPlanIndex?pageIndex=' + obj.curr;
                    }
                }
                , hash: 'fenye' //自定义hash值
            });
    });
    finish = function (id) {
        $.get(""/EnterCustom/FinishPlan?id="" + id, function (res) {
            window.location.reload();
         })
    }
    del = function (id) {
        layer.confirm('确定要删除吗？', {
            btn: ['确定', '取消'] //按钮
        }, function () {
            $.get(""/EnterCustom/DelPlan?id="" + id, function (res) {
                layer.msg('删除成功', { icon: 1 });
                window.location.reload();
            })
        }, function () {

        });
    }
    var showcontroller = function (id) {
        layer.open({
            type: 2,
            title: '联系人列表',
            shadeClose: true,
            shade: 0.8,
       ");
                WriteLiteral(@"     area: ['1200px', '50%'],
            content: '/EnterCustom/EnterCustContactsList?EnterCustID=' + id
        });
    }
    updatephase = function (id) {
        layer.open({
            type: 2,
            title: '更新客户所处阶段',
            shadeClose: true,
            shade: 0.8,
            area: ['1200px', '70%'],
            content: '/EnterCustom/AddEnterCustPhaseLog?id=' + id
        });
    }
    addplan = function (id) {
        layer.open({
            type: 2,
            title: '添加工作计划',
            shadeClose: true,
            shade: 0.8,
            area: ['400px', '40%'],
            content: '/EnterCustom/AddWorkPlan?EnterCustID=' + id
        });
    }
</script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WorkPlan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
