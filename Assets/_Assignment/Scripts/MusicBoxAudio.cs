using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicBoxAudio : MonoBehaviour
{
    private AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    private void OnEnable()
    {
        if (audioSource.clip != null)
            audioSource.Play();
    }

    private void OnDisable()
    {
        audioSource.Stop();
    }
}
