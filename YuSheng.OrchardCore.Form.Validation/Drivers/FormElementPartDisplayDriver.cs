using System.Threading.Tasks;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using YuSheng.OrchardCore.Form.Validation.Models;
using YuSheng.OrchardCore.Form.Validation.ViewModels;

namespace YuSheng.OrchardCore.Form.Validation.Drivers
{
    public class FormElementPartDisplayDriver : ContentPartDisplayDriver<FormElementPart>
    {
        public override IDisplayResult Edit(FormElementPart part)
        {
            return Initialize<FormElementPartEditViewModel>("FormElementPart_Fields_Edit", m =>
            {
                m.Id = part.Id;
            });
        }

        public async override Task<IDisplayResult> UpdateAsync(FormElementPart part, IUpdateModel updater)
        {
            var viewModel = new FormElementPartEditViewModel();

            if (await updater.TryUpdateModelAsync(viewModel, Prefix))
            {
                part.Id = viewModel.Id?.Trim();
            }

            return Edit(part);
        }
    }
}
