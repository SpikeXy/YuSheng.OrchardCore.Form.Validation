using System.Threading.Tasks;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using YuSheng.OrchardCore.Form.Validation.Models;
using YuSheng.OrchardCore.Form.Validation.ViewModels;

namespace YuSheng.OrchardCore.Form.Validation.Drivers
{
    public class ValidationPartDisplayDriver : ContentPartDisplayDriver<ValidationPart>
    {
        public override IDisplayResult Display(ValidationPart part)
        {
            return View("ValidationPart", part).Location("Detail", "Content");
        }

        public override IDisplayResult Edit(ValidationPart part)
        {
            return Initialize<ValidationPartEditViewModel>("ValidationPart_Fields_Edit", m =>
            {
                m.For = part.For;
            });
        }

        public async override Task<IDisplayResult> UpdateAsync(ValidationPart part, IUpdateModel updater)
        {
            var viewModel = new ValidationPartEditViewModel();

            if (await updater.TryUpdateModelAsync(viewModel, Prefix))
            {
                part.For = viewModel.For?.Trim();
            }

            return Edit(part);
        }
    }
}
