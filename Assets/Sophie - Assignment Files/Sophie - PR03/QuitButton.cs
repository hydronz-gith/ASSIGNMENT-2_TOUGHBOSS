using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // stops play mode in editor
        #else
        Application.Quit(); // quits the built game
        #endif
    }
}
