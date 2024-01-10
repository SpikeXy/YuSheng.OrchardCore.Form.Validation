using OrchardCore.ContentManagement;

namespace YuSheng.OrchardCore.Form.Validation.Models
{
    public class InputPart : ContentPart
    {
        public string Type { get; set; }
        public string DefaultValue { get; set; }
        public string Placeholder { get; set; }
    }
}
