using Autofac;
using Template.Core.Interfaces;
using Template.Core.Services;

namespace Template.Core;

public class DefaultCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ToDoItemSearchService>()
            .As<IToDoItemSearchService>().InstancePerLifetimeScope();

        builder.RegisterType<DeleteContributorService>()
            .As<IDeleteContributorService>().InstancePerLifetimeScope();
    }
}
