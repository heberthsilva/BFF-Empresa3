using System;
using System.Collections.Generic;

namespace Business.Models.User
{
    public class OrgaoEmissorDTO
    {
        public short CodigoOrgaoEmissor { get; set; }
        public string OrgaoEmissor { get; set; }
        public bool OrgaoEmissorInativo { get; set; }
    }
}
