using UnityEngine;

public class PlaySoundOnHit : MonoBehaviour
{
    public AudioClip enemyCrash;
    public AudioClip platformLanding;
    private AudioSource audioSource;
    private bool isJumping = false;

    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            audioSource.PlayOneShot(platformLanding, 1.0f);
            animator.SetBool("isJumping", true);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            audioSource.PlayOneShot(enemyCrash, 1.0f);
            animator.SetBool("isJumping", false);

        }
    }
}
