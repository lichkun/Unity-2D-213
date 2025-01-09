

using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    class GameState
    {
        public static ModalScript modalScriptInstance;

        public static bool isLevelCompleted;
        public static int sceneNumber = 0;
        public readonly static int sceneMax = SceneManager.sceneCount;

        public static void Pause(string title = null, string message = null)
        {
            modalScriptInstance.ShowModal(true, title, message);
        }

    }
}