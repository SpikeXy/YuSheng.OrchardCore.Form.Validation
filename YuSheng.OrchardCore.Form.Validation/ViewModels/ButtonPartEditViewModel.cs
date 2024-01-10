using System.ComponentModel.DataAnnotations;

namespace YuSheng.OrchardCore.Form.Validation.ViewModels
{
    public class ButtonPartEditViewModel
    {
        [Required]
        public string Text { get; set; }

        public string Type { get; set; }
    }
}
