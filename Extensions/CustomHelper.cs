using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorials9AM.Extensions
{
    public static class CustomHelper
    {
        public static HtmlString LabelWithBold1(string content)
        {
            string htmlString = String.Format("<label><strong>{0}</strong></label>", content);

            HtmlString str = new HtmlString(htmlString);
            return str;
        }

    }
}