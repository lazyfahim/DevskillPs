using Autofac;

namespace School.Services
{
    public class ServiceModule : Module
    {
        public ServiceModule()
        {
            
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<StudentService>().As<IStudentService>()
                .InstancePerLifetimeScope();
        }
    }
}