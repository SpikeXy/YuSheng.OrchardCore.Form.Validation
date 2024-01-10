using GraphQL.Types;
using YuSheng.OrchardCore.Form.Validation.Models;

namespace YuSheng.OrchardCore.Form.Validation.GraphQL
{
    public class ValidationPartQueryObjectType : ObjectGraphType<ValidationPart>
    {
        public ValidationPartQueryObjectType()
        {
            Name = "ValidationPart";

            Field(x => x.For, nullable: true);
        }
    }
}
