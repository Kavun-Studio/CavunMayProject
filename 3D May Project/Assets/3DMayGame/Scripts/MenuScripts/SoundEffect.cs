using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource soundPlay;

    public void PlaySoundEffect()
    {
        soundPlay.Play();
    }
}
