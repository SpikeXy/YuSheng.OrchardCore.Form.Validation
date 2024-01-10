using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrchardCore.Security.Permissions;

namespace YuSheng.OrchardCore.Form.Validation
{
    public class Permissions : IPermissionProvider
    {
        public static readonly Permission ValidationRule = new Permission(nameof(ValidationRule), "Validate input by rule");

        public Task<IEnumerable<Permission>> GetPermissionsAsync()
        {
            return Task.FromResult(new[] { ValidationRule }.AsEnumerable());
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes()
        {
            return new[]
            {
                new PermissionStereotype
                {
                    Name = "Administrator",
                    Permissions = new[] { ValidationRule }
                }
            };
        }
    }
}
