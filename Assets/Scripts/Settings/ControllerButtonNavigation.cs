using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem; // Required for haptics

public class ControllerButtonNavigation : MonoBehaviour
{
    [SerializeField] private GameObject firstSelectedButton; // First button to be selected.
    [SerializeField] private float vibrationDuration = 0.1f; // Duration of vibration in seconds.
    [SerializeField] private float vibrationStrength = 0.5f; // Intensity of vibration (0 to 1).
    private EventSystem eventSystem;
    private GameObject currentSelected;

    private void Awake()
    {
        // Grab a reference to the EventSystem.
        eventSystem = EventSystem.current;
    }

    private void Start()
    {
        // Set the initial selected button.
        if (firstSelectedButton != null)
        {
            eventSystem.SetSelectedGameObject(firstSelectedButton);
            currentSelected = firstSelectedButton;
        }
    }

    private void Update()
    {
        // Get controller navigation inputs (D-pad or joystick).
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Ensure a button is selected, re-select if none is active.
        if (eventSystem.currentSelectedGameObject == null)
        {
            eventSystem.SetSelectedGameObject(currentSelected);
        }
        else
        {
            // If a new button is selected, vibrate.
            if (currentSelected != eventSystem.currentSelectedGameObject)
            {
                currentSelected = eventSystem.currentSelectedGameObject;
                TriggerVibration();
            }
        }

        // Optional: Add button activation via controller (e.g., A button on Xbox).
        if (Input.GetButtonDown("Submit"))
        {
            var button = eventSystem.currentSelectedGameObject?.GetComponent<UnityEngine.UI.Button>();
            if (button != null)
            {
                button.onClick.Invoke(); // Trigger the button click.
                TriggerVibration();
            }
        }
    }

    private void TriggerVibration()
    {
        // Use the Input System to trigger haptics (vibration).
        if (Gamepad.current != null)
        {
            Gamepad.current.SetMotorSpeeds(vibrationStrength, vibrationStrength); // Set vibration intensity for both motors.
            Invoke(nameof(StopVibration), vibrationDuration); // Stop vibration after a short delay.
        }
    }

    private void StopVibration()
    {
        if (Gamepad.current != null)
        {
            Gamepad.current.SetMotorSpeeds(0, 0); // Stop vibration.
        }
    }
}
