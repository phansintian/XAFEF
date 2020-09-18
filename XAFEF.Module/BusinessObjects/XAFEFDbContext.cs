using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EF.DesignTime;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using DevExpress.Persistent.BaseImpl.EF.Kpi;
using DevExpress.Persistent.BaseImpl.EF.StateMachine;
using DevExpress.ExpressApp.Workflow.EF;
using DevExpress.ExpressApp.Workflow.Versioning;
using DevExpress.Workflow.EF;

namespace XAFEF.Module.BusinessObjects {
	public class XAFEFContextInitializer : DbContextTypesInfoInitializerBase {
		protected override DbContext CreateDbContext() {
			DbContextInfo contextInfo = new DbContextInfo(typeof(XAFEFDbContext), new DbProviderInfo(providerInvariantName: "System.Data.SqlClient", providerManifestToken: "2008"));
            return contextInfo.CreateInstance();
		}
	}
	[TypesInfoInitializer(typeof(XAFEFContextInitializer))]
	public class XAFEFDbContext : DbContext {
		public XAFEFDbContext(String connectionString)
			: base(connectionString) {
		}
		public XAFEFDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public XAFEFDbContext() {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
	    public DbSet<PermissionPolicyRole> Roles { get; set; }
		public DbSet<PermissionPolicyTypePermissionObject> TypePermissionObjects { get; set; }
		public DbSet<PermissionPolicyUser> Users { get; set; }
		public DbSet<Event> Events { get; set; }
		public DbSet<Resource> Resources { get; set; }
		public DbSet<FileData> FileData { get; set; }
		public DbSet<DashboardData> DashboardData { get; set; }
		public DbSet<Analysis> Analysis { get; set; }
		public DbSet<HCategory> HCategories { get; set; }
        public DbSet<KpiDefinition> KpiDefinition { get; set; }
        public DbSet<KpiInstance> KpiInstance { get; set; }
        public DbSet<KpiHistoryItem> KpiHistoryItem { get; set; }
        public DbSet<KpiScorecard> KpiScorecard { get; set; }
		public DbSet<StateMachine> StateMachines { get; set; }
		public DbSet<StateMachineState> StateMachineStates { get; set; }
		public DbSet<StateMachineTransition> StateMachineTransitions { get; set; }
		public DbSet<StateMachineAppearance> StateMachineAppearances { get; set; }
		public DbSet<ReportDataV2> ReportDataV2 { get; set; }
		public DbSet<ModelDifference> ModelDifferences { get; set; }
		public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
		public DbSet<EFWorkflowDefinition> EFWorkflowDefinition { get; set; }
        public DbSet<EFStartWorkflowRequest> EFStartWorkflowRequest { get; set; }
        public DbSet<EFRunningWorkflowInstanceInfo> EFRunningWorkflowInstanceInfo { get; set; }
        public DbSet<EFWorkflowInstanceControlCommandRequest> EFWorkflowInstanceControlCommandRequest { get; set; }
        public DbSet<EFInstanceKey> EFInstanceKey { get; set; }
        public DbSet<EFTrackingRecord> EFTrackingRecord { get; set; }
        public DbSet<EFWorkflowInstance> EFWorkflowInstance { get; set; }
        public DbSet<EFUserActivityVersion> EFUserActivityVersion { get; set; }
	}
}