using EnglishTest.Data.Repositories;
using EnglishTest.Service.Services;
using System;

using Unity;

namespace EnglishTest.Web
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            container.RegisterType<IAnswerRepository, AnswerRepository>();
            container.RegisterType<IAnswerService, AnswerService>();

            container.RegisterType<ILevelRepository, LevelRepository>();
            container.RegisterType<ILevelService, LevelService>();

            container.RegisterType<IPositionRepository, PositionRepository>();
            container.RegisterType<IPositionService, PositionService>();

            container.RegisterType<IQuestionRepository, QuestionRepository>();
            container.RegisterType<IQuestionService, QuestionService>();

            container.RegisterType<IResultRepository, ResultRepository>();
            container.RegisterType<IResultService, ResultService>();

            container.RegisterType<ITestKitRepository, TestKitRepository>();
            container.RegisterType<ITestKitService, TestKitService>();

            container.RegisterType<IUnitRepository, UnitRepository>();
            container.RegisterType<IUnitService, UnitService>();

            container.RegisterType<IUserAdminRepository, UserAdminRepository>();
            container.RegisterType<IUserAdminService, UserAdminService>();

            container.RegisterType<IUserCandidateRepository, UserCandidateRepository>();
            container.RegisterType<IUserCandidateService, UserCandidateService>();
        }
    }
}