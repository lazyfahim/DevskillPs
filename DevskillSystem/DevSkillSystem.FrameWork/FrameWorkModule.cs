using Autofac;

namespace DevSkillSystem.FrameWork
{
    public class FrameWorkModule:Module
    {
        private readonly string _connectionStringName;
        private readonly string _migrationAssemblyName;
        public FrameWorkModule(string connectionStringName, string migrationAssemblyName)
        {
            _connectionStringName = connectionStringName;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FrameWorkContext>()
                .WithParameter("connectionStringName", _connectionStringName)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();
            builder.RegisterType<TransactionUnitOfWork>()
                .As<ITransactionUnitOfWork>()
                .InstancePerLifetimeScope();
            builder.RegisterType<TransactionRepository>()
                .As<ITransactionRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<TransactionService>()
                .As<ITransactionService>()
                .InstancePerLifetimeScope();
                
                
            base.Load(builder);
        }
    }
}