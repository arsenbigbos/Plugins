using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace SB.Shared.Models.Dynamics
{
	// Do not modify the content of this file.
	// This is an automatically generated file and all 
	// logic should be added in the associated controller class
	// If a controller does not exist, create one that inherits the model.

	public class AccountModel : EntityBase
	{
		// Public static Logical Name
		public const string
			LogicalName = "account";

		#region Attribute Names
		public static class Fields
		{
			public const string
				AccountName = "name",
				Email = "emailaddress1",
				PrimaryId = "accountid";

			public static string[] All => new[] { AccountName,
				Email,
				PrimaryId };
		}
		#endregion

		#region Enums
		
		#endregion

		#region Field Definitions
		public string AccountName
		{
			get => (string)this[Fields.AccountName];
			set => this[Fields.AccountName] = value; 
		}
		public string Email
		{
			get => (string)this[Fields.Email];
			set => this[Fields.Email] = value; 
		}
		#endregion

		#region Constructors
		protected AccountModel()
			: base(LogicalName) { }
		protected AccountModel(IOrganizationService service)
			: base(LogicalName, service) { }
		protected AccountModel(Guid id, ColumnSet columnSet, IOrganizationService service)
			: base(service.Retrieve(LogicalName, id, columnSet), service) { }
		protected AccountModel(Guid id, IOrganizationService service)
			: base(LogicalName, id, service) { }
		protected AccountModel(Entity entity, IOrganizationService service)
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