using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCursos.Recursos
{
    public class MyIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError ConcurrencyFailure()
        {
           
            return new IdentityError
            {
                Code = nameof(ConcurrencyFailure),
                Description = "El concurrency ya se encuentra registrada en la base de datos "
            };
        }
        public override IdentityError DefaultError()
        {
            return new IdentityError
            {
                Code = nameof(DefaultError),
                Description = "El default ya se encuentra registrada en la base de datos "
            };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateEmail),
                Description = "El email ya se encuentra registrada en la base de datos "
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = "se requiere al menos un caracter especial "
            };
        }
    }
}
