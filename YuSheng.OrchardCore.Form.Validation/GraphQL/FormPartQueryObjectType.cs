using GraphQL.Types;
using YuSheng.OrchardCore.Form.Validation.Models;

namespace YuSheng.OrchardCore.Form.Validation.GraphQL
{
    public class FormPartQueryObjectType : ObjectGraphType<FormPart>
    {
        public FormPartQueryObjectType()
        {
            Name = "FormPart";

            Field(x => x.WorkflowTypeId, nullable: true);
            Field(x => x.Action, nullable: true);
            Field(x => x.Method, nullable: true);
        }
    }
}
