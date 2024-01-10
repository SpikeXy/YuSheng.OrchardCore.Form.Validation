using OrchardCore.ContentManagement;

namespace YuSheng.OrchardCore.Form.Validation.Models
{
    public class SelectPart : ContentPart
    {
        public SelectOption[] Options { get; set; }
        public string DefaultValue { get; set; }
    }

    public class SelectOption
    {
        public string Text { get; set; }

        public string Value { get; set; }
    }
}
