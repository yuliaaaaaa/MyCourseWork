using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // ����������� ��� ���� �� ��'���, �� ����� ����������� ��� ������
    public void ExitGameButtonClicked()
    {
        // �������� � ���
        Application.Quit();

#if UNITY_EDITOR
        // ��� ���� ���� ��� ������������ � �������� Unity
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}