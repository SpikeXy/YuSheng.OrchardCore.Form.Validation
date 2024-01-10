using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.DisplayManagement.Views;
using YuSheng.OrchardCore.Form.Validation.Models;

namespace YuSheng.OrchardCore.Form.Validation.Drivers
{
    public class ValidationSummaryPartDisplayDriver : ContentPartDisplayDriver<ValidationSummaryPart>
    {
        public override IDisplayResult Display(ValidationSummaryPart part)
        {
            return View("ValidationSummaryPart", part).Location("Detail", "Content");
        }

        public override IDisplayResult Edit(ValidationSummaryPart part)
        {
            return View("ValidationSummaryPart_Fields_Edit", part);
        }
    }
}
