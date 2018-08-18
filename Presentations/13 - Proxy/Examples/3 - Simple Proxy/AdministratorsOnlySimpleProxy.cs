using System.Collections.Generic;
using System.Security;
using System.Security.Principal;
using Wincubate.ProxyExamples.WebShop;

namespace Wincubate.ProxyExamples
{
    class AdministratorsOnlySimpleProxy : ProductRepository
    {
        public override void Add( Product product )
        {
            EnsureAdministrator();

            base.Add(product);
        }

        private void EnsureAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            if (principal.IsInRole(WindowsBuiltInRole.Administrator) == false )
            {
                throw new SecurityException($"User {identity.Name} is not authorized for access");
            }
        }
    }
}