using YuSheng.OrchardCore.Form.Validation.Workflows.Activities;
using YuSheng.OrchardCore.Form.Validation.Workflows.ViewModels;
using OrchardCore.Workflows.Display;

namespace YuSheng.OrchardCore.Form.Validation.Workflows.Drivers
{
    public class ValidateFormFieldTaskDisplayDriver : ActivityDisplayDriver<ValidateFormFieldTask, ValidateFormFieldTaskViewModel>
    {
        protected override void EditActivity(ValidateFormFieldTask activity, ValidateFormFieldTaskViewModel model)
        {
            model.FieldName = activity.FieldName;
            model.ErrorMessage = activity.ErrorMessage;
        }

        protected override void UpdateActivity(ValidateFormFieldTaskViewModel model, ValidateFormFieldTask activity)
        {
            activity.FieldName = model.FieldName?.Trim();
            activity.ErrorMessage = model.ErrorMessage?.Trim();
        }
    }
}
