using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using AspBoilerPlate.MyProject.EntityFramework;

namespace AspBoilerPlate.MyProject.Migrator
{
    [DependsOn(typeof(MyProjectDataModule))]
    public class MyProjectMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyProjectDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}