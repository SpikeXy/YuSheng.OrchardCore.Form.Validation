using GraphQL.Types;
using YuSheng.OrchardCore.Form.Validation.Models;

namespace YuSheng.OrchardCore.Form.Validation.GraphQL
{
    public class ValidationSummaryPartQueryObjectType : ObjectGraphType<ValidationSummaryPart>
    {
        public ValidationSummaryPartQueryObjectType()
        {
            Name = "ValidationSummaryPart";
        }
    }
}
