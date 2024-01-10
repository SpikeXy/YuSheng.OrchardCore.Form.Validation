using System.Collections.Generic;
using OrchardCore.DisplayManagement.Views;
using YuSheng.OrchardCore.Form.Validation.Models;

namespace YuSheng.OrchardCore.Form.Validation.ViewModels
{
    public class ValidationRulePartEditViewModel : ShapeViewModel
    {
        public string Type { get; set; }
        public string Option { get; set; }
        public string ErrorMessage { get; set; }
        public IEnumerable<ValidationRuleProvider> ValidationRuleProviders { get;set;  }
    }
}
