using TMPro;
using UnityEngine;

public class UIUpdaterScript : MonoBehaviour
{
    // Змінна для зберігання іншого скрипта
    public StopwatchScript stopwatchScript;

    // Змінна для TextMeshProUGUI
    private TextMeshProUGUI textMeshProUGUIComponent;

    void Start()
    {
        textMeshProUGUIComponent = GetComponent<TextMeshProUGUI>();

        if (stopwatchScript == null)
        {
            Debug.LogError("Скрипт StopwatchScript не знайдено. Додайте компонент до об'єкта!");
        }

        if (textMeshProUGUIComponent == null)
        {
            Debug.LogError("Компонент TextMeshProUGUI не знайдено. Додайте компонент до об'єкта!");
        }
    }

    void Update()
    {
        // Оновлення інтерфейсу
        if (stopwatchScript != null && textMeshProUGUIComponent != null)
        {
            float elapsedTime = stopwatchScript.GetElapsedTime();
            textMeshProUGUIComponent.text = "Time: " + elapsedTime.ToString("F0") + " sec";
            //ПІДКЛЮЧЕННЯ ДО БД---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }

    // Метод для оновлення значення секунд
    public void UpdateElapsedTime(float elapsedTime)
    {
        if (textMeshProUGUIComponent != null)
        {
            textMeshProUGUIComponent.text = "Час: " + elapsedTime.ToString("F0") + " с";
        }
    }
}