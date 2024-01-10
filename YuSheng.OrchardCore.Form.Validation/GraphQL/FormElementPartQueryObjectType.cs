using GraphQL.Types;
using YuSheng.OrchardCore.Form.Validation.Models;

namespace YuSheng.OrchardCore.Form.Validation.GraphQL
{
    public class FormElementPartQueryObjectType : ObjectGraphType<FormElementPart>
    {
        public FormElementPartQueryObjectType()
        {
            Name = "FormElementPart";

            Field(x => x.Id, nullable: true);
        }
    }
}
