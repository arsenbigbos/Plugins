using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using SB.Shared.Models.Dynamics;
using System;

namespace SB.Shared.EntityProviders
{
    public class Account : AccountModel
    {
        public Account(IOrganizationService service) : base(service) { }
        public Account(IOrganizationService service, Guid id) : base(id, service) { }
        public Account(Guid id, ColumnSet columnSet, IOrganizationService service)
                : base(service.Retrieve(LogicalName, id, columnSet), service) { }
        public Account(Entity entity, IOrganizationService service) : base(entity, service) { }
    }
}
