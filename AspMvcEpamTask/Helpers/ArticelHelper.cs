using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvcEpamTask.Helpers
{
    public static class ArticelHelper
    {
        public static MvcHtmlString CreateList(this HtmlHelper html, string[] items, bool isOrdered)
        {
            TagBuilder tagUlOrOl;
            if (isOrdered) tagUlOrOl = new TagBuilder("ol");
            else tagUlOrOl = new TagBuilder("ul");
            foreach (string item in items)
            {
                TagBuilder li = new TagBuilder("li");
                li.SetInnerText(item);
                tagUlOrOl.InnerHtml += li.ToString();

            }
            return new MvcHtmlString(tagUlOrOl.ToString());
        }
    }
}