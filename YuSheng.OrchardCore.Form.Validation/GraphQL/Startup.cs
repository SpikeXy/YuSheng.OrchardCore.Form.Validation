using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Apis;
using YuSheng.OrchardCore.Form.Validation.Models;
using OrchardCore.Modules;

namespace YuSheng.OrchardCore.Form.Validation.GraphQL
{
    [RequireFeatures("OrchardCore.Apis.GraphQL")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddObjectGraphType<FormPart, FormPartQueryObjectType>();
            services.AddObjectGraphType<FormElementPart, FormElementPartQueryObjectType>();
            services.AddObjectGraphType<FormInputElementPart, FormInputElementPartQueryObjectType>();
            services.AddObjectGraphType<LabelPart, LabelPartQueryObjectType>();
            services.AddObjectGraphType<ButtonPart, ButtonPartQueryObjectType>();
            services.AddObjectGraphType<InputPart, InputPartQueryObjectType>();
            services.AddObjectGraphType<TextAreaPart, TextAreaPartQueryObjectType>();
            services.AddObjectGraphType<ValidationPart, ValidationPartQueryObjectType>();

            // Broken
            //services.AddGraphQLQueryType<ValidationSummaryPart, ValidationSummaryPartQueryObjectType>();
        }
    }
}
