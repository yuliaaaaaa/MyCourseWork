using UnityEngine;

public class Hits : MonoBehaviour
{
    public AudioSource[] AudioArray;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int random_index = Random.Range(0, AudioArray.Length);
        AudioSource HitAudio = AudioArray[random_index];
        HitAudio.Play();
    }
}

