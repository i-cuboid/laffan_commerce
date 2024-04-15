﻿using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Grand.Web.Common.TagHelpers;

[HtmlTargetElement("input", Attributes = ForAttributeName)]
public class InputTagHelper : Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper
{
    private const string ForAttributeName = "asp-for";

    public InputTagHelper(IHtmlGenerator generator) : base(generator)
    {
    }

    [HtmlAttributeName("asp-disabled")] public string IsDisabled { set; get; }

    [HtmlAttributeName("asp-readonly")] public bool IsReadonly { set; get; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        bool.TryParse(IsDisabled, out var disabled);
        if (disabled)
        {
            var d = new TagHelperAttribute("disabled", "disabled");
            output.Attributes.Add(d);
        }

        if (IsReadonly)
        {
            var d = new TagHelperAttribute("readonly");
            output.Attributes.Add(d);
        }

        base.Process(context, output);
    }
}