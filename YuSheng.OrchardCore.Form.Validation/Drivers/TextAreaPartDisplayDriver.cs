using System.Threading.Tasks;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using YuSheng.OrchardCore.Form.Validation.Models;
using YuSheng.OrchardCore.Form.Validation.ViewModels;

namespace YuSheng.OrchardCore.Form.Validation.Drivers
{
    public class TextAreaPartDisplayDriver : ContentPartDisplayDriver<TextAreaPart>
    {
        public override IDisplayResult Display(TextAreaPart part)
        {
            return View("TextAreaPart", part).Location("Detail", "Content");
        }

        public override IDisplayResult Edit(TextAreaPart part)
        {
            return Initialize<TextAreaPartEditViewModel>("TextAreaPart_Fields_Edit", m =>
            {
                m.Placeholder = part.Placeholder;
                m.DefaultValue = part.DefaultValue;
            });
        }

        public async override Task<IDisplayResult> UpdateAsync(TextAreaPart part, IUpdateModel updater)
        {
            var viewModel = new InputPartEditViewModel();

            if (await updater.TryUpdateModelAsync(viewModel, Prefix))
            {
                part.Placeholder = viewModel.Placeholder?.Trim();
                part.DefaultValue = viewModel.DefaultValue?.Trim();
            }

            return Edit(part);
        }
    }
}
