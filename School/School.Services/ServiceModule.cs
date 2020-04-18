using Autofac;
using School.Data;

namespace School.Services
{
    public class ServiceModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;
        public ServiceModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<StudentService>().As<IStudentService>()
                .WithParameter("schoolUnitOfWork",new SchoolUnitOfWork(_connectionString,_migrationAssemblyName))
                .InstancePerLifetimeScope();
        }
    }
}