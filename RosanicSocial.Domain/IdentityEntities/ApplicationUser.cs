using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace RosanicSocial.Domain.IdentityEntities {
    public class ApplicationUser : IdentityUser<Guid> {
        public string? PersonName { get; set; }
    }
}
