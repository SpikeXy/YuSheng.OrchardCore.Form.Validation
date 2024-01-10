using GraphQL.Types;
using YuSheng.OrchardCore.Form.Validation.Models;

namespace YuSheng.OrchardCore.Form.Validation.GraphQL
{
    public class FormInputElementPartQueryObjectType : ObjectGraphType<FormInputElementPart>
    {
        public FormInputElementPartQueryObjectType()
        {
            Name = "FormInputElementPart";

            Field(x => x.Name, nullable: true);
        }
    }
}
