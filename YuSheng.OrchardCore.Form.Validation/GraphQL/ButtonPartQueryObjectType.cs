using GraphQL.Types;
using YuSheng.OrchardCore.Form.Validation.Models;

namespace YuSheng.OrchardCore.Form.Validation.GraphQL
{
    public class ButtonPartQueryObjectType : ObjectGraphType<ButtonPart>
    {
        public ButtonPartQueryObjectType()
        {
            Name = "ButtonPart";

            Field(x => x.Text, nullable: true);
            Field(x => x.Type, nullable: true);
        }
    }
}
