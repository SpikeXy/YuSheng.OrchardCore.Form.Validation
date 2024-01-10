using System.ComponentModel.DataAnnotations;

namespace YuSheng.OrchardCore.Form.Validation.Workflows.ViewModels
{
    public class ValidateFormFieldTaskViewModel
    {
        [Required]
        public string FieldName { get; set; }

        [Required]
        public string ErrorMessage { get; set; }
    }
}
