using GraphQL.Types;
using YuSheng.OrchardCore.Form.Validation.Models;

namespace YuSheng.OrchardCore.Form.Validation.GraphQL
{
    public class InputPartQueryObjectType : ObjectGraphType<InputPart>
    {
        public InputPartQueryObjectType()
        {
            Name = "InputPart";

            Field(x => x.Type, nullable: true);
            Field(x => x.Placeholder, nullable: true);
            Field(x => x.DefaultValue, nullable: true);
        }
    }
}
