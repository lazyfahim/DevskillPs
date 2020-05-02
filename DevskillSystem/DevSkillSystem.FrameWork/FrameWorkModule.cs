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
            builder.RegisterType<StudentUnitOfWork>()
                .As<IStudentUnitOfWork>()
                .InstancePerLifetimeScope();
            builder.RegisterType<StudentRepository>()
                .As<IStudentRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<SubjectRepository>()
                .As<ISubjectRepository>()
                .InstancePerLifetimeScope();
            
                
            base.Load(builder);
        }
    }
}