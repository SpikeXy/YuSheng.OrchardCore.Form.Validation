using OrchardCore.ContentManagement;
using OrchardCore.DisplayManagement.Shapes;

namespace YuSheng.OrchardCore.Form.Validation.Models
{
    public class ValidationRulePart : ContentPart
    {
        public string Type { get; set; }
        public string Option { get; set; }
        public string ErrorMessage { get; set; }
    }
}
