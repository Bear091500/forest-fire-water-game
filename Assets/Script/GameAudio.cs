using UnityEngine;

public class GameAudio : MonoBehaviour
{
    public AudioSource audioplayer;
    public AudioClip scoreClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReplayBackgroundMusic()
    {
        audioplayer.Play();
    }public void Scoresound()
    {
        audioplayer.PlayOneShot(scoreClip);
    }
}
