using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OctopusCore.Srv
{
    /// <summary>
    /// Třída která mi umožňuje přijímat zprávy ve formátu plain text
    /// </summary>
    public class PlainTextInputFormatter : InputFormatter
    {
        public PlainTextInputFormatter()
        {
            this.SupportedMediaTypes.Add("text/plain");
        }

        public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            var request = context.HttpContext.Request;
            using (var reader = new StreamReader(request.Body))
            {
                var content = await reader.ReadToEndAsync();
                return await InputFormatterResult.SuccessAsync(content);
            }
        }

        protected override bool CanReadType(Type type)
        {
            return type == typeof(string);
        }
    }
}
