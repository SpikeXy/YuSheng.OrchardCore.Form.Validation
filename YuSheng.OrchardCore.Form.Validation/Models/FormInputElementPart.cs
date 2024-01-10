using OrchardCore.ContentManagement;

namespace YuSheng.OrchardCore.Form.Validation.Models
{
    /// <summary>
    /// Turns a content item into a form element that supports input.
    /// </summary>
    public class FormInputElementPart : ContentPart
    {
        public string Name { get; set; }
    }
}
