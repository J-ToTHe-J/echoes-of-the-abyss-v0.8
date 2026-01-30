using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderLVL4 : MonoBehaviour
{
    [SerializeField] private string sceneName; // Name of the scene to load

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Load the specified scene
            SceneManager.LoadScene(13);
        }
    }
}