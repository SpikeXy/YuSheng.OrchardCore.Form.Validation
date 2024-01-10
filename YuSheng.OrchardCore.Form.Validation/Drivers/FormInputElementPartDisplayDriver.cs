using System.Threading.Tasks;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using YuSheng.OrchardCore.Form.Validation.Models;
using YuSheng.OrchardCore.Form.Validation.ViewModels;

namespace YuSheng.OrchardCore.Form.Validation.Drivers
{
    public class FormInputElementPartDisplayDriver : ContentPartDisplayDriver<FormInputElementPart>
    {
        public override IDisplayResult Edit(FormInputElementPart part)
        {
            return Initialize<FormInputElementPartEditViewModel>("FormInputElementPart_Fields_Edit", m =>
            {
                m.Name = part.Name;
            });
        }

        public async override Task<IDisplayResult> UpdateAsync(FormInputElementPart part, IUpdateModel updater)
        {
            var viewModel = new FormInputElementPartEditViewModel();

            if (await updater.TryUpdateModelAsync(viewModel, Prefix))
            {
                part.Name = viewModel.Name?.Trim();
                part.ContentItem.DisplayText = part.Name;
            }

            return Edit(part);
        }
    }
}
