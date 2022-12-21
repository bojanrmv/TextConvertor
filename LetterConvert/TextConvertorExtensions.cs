using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextConvert;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class TextConvertorExtensions
    {
        public static IServiceCollection AddTextConvertor(this IServiceCollection services)
        {
            services.AddScoped<ITextConvertor, TextConvertor>();
            return services;
        }
    }
}
