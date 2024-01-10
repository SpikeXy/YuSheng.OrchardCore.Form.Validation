using Microsoft.AspNetCore.Mvc.Filters;

namespace YuSheng.OrchardCore.Form.Validation.Filters
{
    public abstract class ModelStateTransferAttribute : ActionFilterAttribute
    {
        internal const string Key = nameof(ModelStateTransferAttribute);
    }
}
