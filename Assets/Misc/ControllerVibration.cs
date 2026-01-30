using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ControllerVibration : MonoBehaviour
{
    private void OnEnable()
    {
        // Subscribe to scene load/unload events to stop vibration
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // Unsubscribe from scene events when this object is disabled or destroyed
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void Update()
    {
        // Check if the Input System recognizes a Gamepad and button press
        if (Gamepad.current != null && Gamepad.current.buttonSouth.wasPressedThisFrame)
        {
            VibrateController(0.5f, 0.5f, 0.2f); // Adjust duration and intensity as needed
        }
    }

    private void VibrateController(float leftMotor, float rightMotor, float duration)
    {
        if (Gamepad.current != null)
        {
            Gamepad.current.SetMotorSpeeds(leftMotor, rightMotor);
            Invoke(nameof(StopVibration), duration);
        }
    }

    private void StopVibration()
    {
        if (Gamepad.current != null)
        {
            Gamepad.current.SetMotorSpeeds(0, 0);
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Stop vibration when the scene changes
        StopVibration();
    }

    private void OnDestroy()
    {
        // Make sure vibration stops when the object is destroyed (e.g., scene change or destruction)
        StopVibration();
    }
}
