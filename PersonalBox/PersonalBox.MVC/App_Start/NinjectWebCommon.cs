[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(PersonalBox.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(PersonalBox.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace PersonalBox.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject.Web.Common;
    using Ninject;
    using Domain.Interfaces.Repositories;
    using Infra.Repositories;
    using Domain.Interfaces.AppServices;
    using Domain.AppServices;
    using Application.Appications.Abstracts;
    using Application.Appications;
    using Application.Appications.Users;
    using Services.Clients;
    using Services.Abstracts;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static object Bind { get; private set; }

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            // Repositories
            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            kernel.Bind<IUserRepository>().To<UserRepository>();

            // AppServices
            kernel.Bind(typeof(IAppService<>)).To(typeof(AppService<>));
            kernel.Bind<IUserAppService>().To<UserAppService>();

            // AppBases
            kernel.Bind(typeof(IAppBase<>)).To(typeof(AppBase<>));
            kernel.Bind<IUserApp>().To<UserApp>();


            // Services           
            kernel.Bind<IUserService>().To<UserService>();
        }
    }
}
