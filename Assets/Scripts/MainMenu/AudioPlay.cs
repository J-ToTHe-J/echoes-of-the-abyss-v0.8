using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource.Play();
    }

    public void PlayAudioClip()
    {
        audioSource.Play();
    }
}
