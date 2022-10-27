using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

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
				CacheUpdateFrequency = "sb_cacheupdatefrequency",
				InvitationWorkflow = "sb_invitationworkflow",
				LastRefreshed = "sb_lastrefreshed", 
				PrimaryId = "sb_customsettingsid",
				PrimaryName = "sb_name",
				UpdateFrequency = "sb_updatefrequency";

			public static string[] All => new[] { CacheUpdateFrequency,
				InvitationWorkflow,
				LastRefreshed,
				PrimaryId,
				PrimaryName,
				UpdateFrequency };
		}
		#endregion

		#region Enums
		
		#endregion

		#region Field Definitions
		public int? CacheUpdateFrequency
		{
			get => (int?)this[Fields.CacheUpdateFrequency];
			set => this[Fields.CacheUpdateFrequency] = value; 
		}
		public EntityReference InvitationWorkflow
		{
			get => (EntityReference)this[Fields.InvitationWorkflow];
			set => this[Fields.InvitationWorkflow] = value; 
		}
		public DateTime? LastRefreshed
		{
			get => (DateTime?)this[Fields.LastRefreshed];
			set => this[Fields.LastRefreshed] = value; 
		}
		public int? UpdateFrequency
		{
			get => (int?)this[Fields.UpdateFrequency];
			set => this[Fields.UpdateFrequency] = value; 
		}
		#endregion

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
		#endregion

		#region Public Methods
		public override string GetPrimaryAttribute()
        {
            return Fields.PrimaryId;
        }
		#endregion
	}
}