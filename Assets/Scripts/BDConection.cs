using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Викликається при кліку на об'єкт, до якого прикріплений цей скрипт
    public void ExitGameButtonClicked()
    {
        // Виходить з гри
        Application.Quit();

#if UNITY_EDITOR
        // Цей блок коду для відлагодження в редакторі Unity
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}