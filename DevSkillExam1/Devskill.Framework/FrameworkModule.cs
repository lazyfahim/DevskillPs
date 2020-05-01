using Autofac;

namespace Devskill.Framework
{
    public class FrameworkModule:Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssembly;
        public FrameworkModule(string connectionString,string migrationAssembly)
        {
            _connectionString = connectionString;
            _migrationAssembly = migrationAssembly;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FrameworkContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssembly", _migrationAssembly)
                .InstancePerLifetimeScope();
            builder.RegisterType<StudentUnitOfWork>().As<IStudentUnitOfWork>()
                .InstancePerLifetimeScope();
            builder.RegisterType<StudentRepository>().As<IStudentRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<StudentService>().As<IStudentService>()
                .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}