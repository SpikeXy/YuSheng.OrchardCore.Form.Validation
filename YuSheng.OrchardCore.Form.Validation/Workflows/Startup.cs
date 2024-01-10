using Microsoft.Extensions.DependencyInjection;
using YuSheng.OrchardCore.Form.Validation.Workflows.Activities;
using YuSheng.OrchardCore.Form.Validation.Workflows.Drivers;
using OrchardCore.Modules;
using OrchardCore.Workflows.Helpers;

namespace YuSheng.OrchardCore.Form.Validation.Workflows
{
    [RequireFeatures("OrchardCore.Workflows")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddActivity<ValidateAntiforgeryTokenTask, ValidateAntiforgeryTokenTaskDisplayDriver>();
            services.AddActivity<AddModelValidationErrorTask, AddModelValidationErrorTaskDisplayDriver>();
            services.AddActivity<ValidateRuleFormTask, ValidateRuleFormTaskDisplayDriver>();
            services.AddActivity<ValidateFormTask, ValidateFormTaskDisplayDriver>();
            services.AddActivity<ValidateFormFieldTask, ValidateFormFieldTaskDisplayDriver>();
            services.AddActivity<BindModelStateTask, BindModelStateTaskDisplayDriver>();
        }
    }
}
