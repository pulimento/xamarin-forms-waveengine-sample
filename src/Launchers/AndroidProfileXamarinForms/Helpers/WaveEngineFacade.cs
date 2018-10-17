using WaveEngine.Framework;
using WaveEngine.Framework.Services;

namespace XamarinForms3DCarSample.Helpers
{
    public static class WaveEngineFacade
    {
        private static MyScene _scene;

        public static void Initialize(MyScene scene)
        {
            _scene = scene;
        }      

        public static ScreenContextManager GetScreenContextManager()
        {
            return WaveServices.ScreenContextManager;
        }

        public static Scene GetCurrentScene()
        {
            if (WaveServices.ScreenContextManager.CurrentContext.Count == 0)
                return null;

            return WaveServices.ScreenContextManager.CurrentContext[0];
        }
    }
}