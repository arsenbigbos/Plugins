using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;

namespace SB.Shared.Models.Dynamics
{
    // Do not modify the content of this file.
    // This is an automatically generated file and all
    // logic should be added in the associated controller class
    // If a controller does not exist, create one that inherits the model.

    public class SBCustomSettingsModel : EntityBase
    {
        // Public static Logical Name
        public const string
            LogicalName = "sb_customsettings";

        #region Attribute Names

        public static class Fields
        {
            public const string
                PrimaryId = "sb_customsettingsid",
                PrimaryName = "sb_name";

            public static string[] All => new[] {
                PrimaryId,
                PrimaryName };
        }

        #endregion Attribute Names

        #region Constructors

        protected SBCustomSettingsModel()
            : base(LogicalName) { }
        protected SBCustomSettingsModel(IOrganizationService service)
            : base(LogicalName, service) { }
        protected SBCustomSettingsModel(Guid id, ColumnSet columnSet, IOrganizationService service)
            : base(service.Retrieve(LogicalName, id, columnSet), service) { }
        protected SBCustomSettingsModel(Guid id, IOrganizationService service)
            : base(LogicalName, id, service) { }
        protected SBCustomSettingsModel(Entity entity, IOrganizationService service)
            : base(entity, service) { }

        #endregion Constructors
    }
}