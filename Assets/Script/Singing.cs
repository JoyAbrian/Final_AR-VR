using UnityEngine;

public class Singing : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponentInChildren<AudioSource>();
    }

    public void StartSinging()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    public void StopSinging()
    {
        audioSource.clip = null;
        audioSource.Stop();
    }
}
