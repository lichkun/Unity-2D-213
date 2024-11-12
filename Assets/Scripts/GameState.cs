using System.Security.Cryptography;
using UnityEngine;
class GameState
{
    public static bool isLevelCompleted;
    public static ModalScript modalScriptInstance;
    public static void Pause(string title = null, string message = null)
    {
        modalScriptInstance.ShowModal(true, title, message);
    }
}
