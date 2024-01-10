using System.Threading.Tasks;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using YuSheng.OrchardCore.Form.Validation.Models;
using YuSheng.OrchardCore.Form.Validation.ViewModels;

namespace YuSheng.OrchardCore.Form.Validation.Drivers
{
    public class InputPartDisplayDriver : ContentPartDisplayDriver<InputPart>
    {
        public override IDisplayResult Display(InputPart part)
        {
            return View("InputPart", part).Location("Detail", "Content");
        }

        public override IDisplayResult Edit(InputPart part)
        {
            return Initialize<InputPartEditViewModel>("InputPart_Fields_Edit", m =>
            {
                m.Placeholder = part.Placeholder;
                m.DefaultValue = part.DefaultValue;
                m.Type = part.Type;
            });
        }

        public async override Task<IDisplayResult> UpdateAsync(InputPart part, IUpdateModel updater)
        {
            var viewModel = new InputPartEditViewModel();

            if (await updater.TryUpdateModelAsync(viewModel, Prefix))
            {
                part.Placeholder = viewModel.Placeholder?.Trim();
                part.DefaultValue = viewModel.DefaultValue?.Trim();
                part.Type = viewModel.Type?.Trim();
            }

            return Edit(part);
        }
    }
}
