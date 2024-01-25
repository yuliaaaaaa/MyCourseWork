using UnityEngine;
using System.Diagnostics;

public class StopwatchScript : MonoBehaviour
{
    private Stopwatch stopwatch;
    private bool isPaused = false;
    public UIUpdaterScript uiUpdaterScript;
    private static int inf;

    void Start()
    {
        stopwatch = new Stopwatch();
        stopwatch.Start();
    }

    void Update()
    {
        if (!isPaused)
        {
            stopwatch.Stop();
            stopwatch.Start();

            float elapsedTime = (float)stopwatch.Elapsed.TotalSeconds;

            if (uiUpdaterScript != null)
            {
                uiUpdaterScript.UpdateElapsedTime(elapsedTime);
                inf = Mathf.CeilToInt(elapsedTime);

            }

            CheckPositionAndPauseTimer();
        }
    }

    public float GetElapsedTime()
    {
        return (float)stopwatch.Elapsed.TotalSeconds;
    }

    public void PauseResumeTimer(bool pause)
    {
        isPaused = pause;

        if (pause)
        {
            stopwatch.Stop();
        }
        else
        {
            stopwatch.Start();
        }
    }
    private void CheckPositionAndPauseTimer()
    {
        FlyBehavior flyBehavior = GetComponent<FlyBehavior>();
        
        if (flyBehavior != null && (flyBehavior.transform.position.x <= -13.5f || flyBehavior.transform.position.y <= -3.9f || flyBehavior.transform.position.y >= 6f))
        {
            PauseResumeTimer(true);
        }
    }

}