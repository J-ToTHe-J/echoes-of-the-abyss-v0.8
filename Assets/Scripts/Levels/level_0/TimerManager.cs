using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public static TimerManager Instance; // Singleton instance
    private float elapsedTime = 0f;      // Tracks total time
    private bool isTimerRunning = false;

    private void Awake()
    {
        // Ensure this object persists across scenes
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        // Increment time if the timer is running
        if (isTimerRunning)
        {
            elapsedTime += Time.deltaTime;
        }
    }

    // Start the timer
    public void StartTimer()
    {
        isTimerRunning = true;
    }

    // Stop the timer
    public void StopTimer()
    {
        isTimerRunning = false;
    }

    // Get the elapsed time
    public float GetElapsedTime()
    {
        return elapsedTime;
    }
}

