using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSceneManager : MonoBehaviour
{
    void Start()
    {
        // Start the global timer when the scene loads
        if (TimerManager.Instance != null)
        {
            TimerManager.Instance.StartTimer();
            Debug.Log("Timer started!");
        }
        else
        {
            Debug.LogWarning("TimerManager instance not found!");
        }
    }
}

