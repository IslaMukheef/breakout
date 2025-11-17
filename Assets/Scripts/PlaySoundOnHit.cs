using UnityEngine;

public class PlaySoundOnHit : MonoBehaviour
{
    public AudioClip enemyCrash;
    public AudioClip platformLanding;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            audioSource.PlayOneShot(platformLanding, 1.0f);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            audioSource.PlayOneShot(enemyCrash, 1.0f);
        }
    }
}
