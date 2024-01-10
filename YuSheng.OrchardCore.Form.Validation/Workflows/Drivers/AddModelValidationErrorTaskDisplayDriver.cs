using YuSheng.OrchardCore.Form.Validation.Workflows.Activities;
using YuSheng.OrchardCore.Form.Validation.Workflows.ViewModels;
using OrchardCore.Workflows.Display;

namespace YuSheng.OrchardCore.Form.Validation.Workflows.Drivers
{
    public class AddModelValidationErrorTaskDisplayDriver : ActivityDisplayDriver<AddModelValidationErrorTask, AddModelValidationErrorTaskViewModel>
    {
        protected override void EditActivity(AddModelValidationErrorTask activity, AddModelValidationErrorTaskViewModel model)
        {
            model.Key = activity.Key;
            model.ErrorMessage = activity.ErrorMessage;
        }

        protected override void UpdateActivity(AddModelValidationErrorTaskViewModel model, AddModelValidationErrorTask activity)
        {
            activity.Key = model.Key?.Trim();
            activity.ErrorMessage = model.ErrorMessage?.Trim();
        }
    }
}
