using System;
using TMPro;
using UnityEngine;

public class UIUpdaterScript : MonoBehaviour
{
    public StopwatchScript stopwatchScript;
    private TextMeshProUGUI textMeshProUGUIComponent;

    static public int score;

    void Start()
    {
        textMeshProUGUIComponent = GetComponent<TextMeshProUGUI>();

        if (stopwatchScript == null)
        {
            Debug.LogError("������ StopwatchScript �� ��������. ������� ��������� �� ��'����!");
        }

        if (textMeshProUGUIComponent == null)
        {
            Debug.LogError("��������� TextMeshProUGUI �� ��������. ������� ��������� �� ��'����!");
        }
    }

    void Update()
    {
        if (stopwatchScript != null && textMeshProUGUIComponent != null)
        {
            float elapsedTime = stopwatchScript.GetElapsedTime();
            textMeshProUGUIComponent.text = "Time: " + elapsedTime.ToString("F0") + " sec";

            score = Convert.ToInt32(elapsedTime);
        }
    }
    
    public void UpdateElapsedTime(float elapsedTime)
    {
        if (textMeshProUGUIComponent != null)
        {
            textMeshProUGUIComponent.text = "���: " + elapsedTime.ToString("F0") + " �";
        }
    }
}