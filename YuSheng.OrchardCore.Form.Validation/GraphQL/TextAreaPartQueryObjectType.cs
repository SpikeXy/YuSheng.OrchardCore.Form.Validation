using GraphQL.Types;
using YuSheng.OrchardCore.Form.Validation.Models;

namespace YuSheng.OrchardCore.Form.Validation.GraphQL
{
    public class TextAreaPartQueryObjectType : ObjectGraphType<TextAreaPart>
    {
        public TextAreaPartQueryObjectType()
        {
            Name = "TextAreaPart";

            Field(x => x.DefaultValue, nullable: true);
            Field(x => x.Placeholder, nullable: true);
        }
    }
}
