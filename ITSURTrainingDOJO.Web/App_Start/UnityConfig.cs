using ITSURTrainingDOJO.Web.Areas.api.Repositories;
using System;

using Unity;

namespace ITSURTrainingDOJO.Web
{
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

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ICourseRepository, CourseMockRepository>();
        }
    }
}