using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    [Header("Components")]
    [SerializeField] private Rigidbody2D ballRb;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Animator animator;
    [Header("Physics Config")]
    public float maxVelocity;
    public float minVelocity;
    [Header("Sound Config")]
    public AudioClip enemyCrash;
    public AudioClip platformLanding;
    [Header("Game Config")] 
    public float deathPlaneY = -4.3f;

    public float deathDelay = 1.5f;
    
    private bool isJumping = false;
    private bool isDead = false;
    

 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        ballRb = GetComponent<Rigidbody2D>();
        ballRb.linearVelocity = new Vector2(0, -minVelocity);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ballRb.linearVelocity.magnitude > maxVelocity)
        {
            ballRb.linearVelocity = Vector2.ClampMagnitude(ballRb.linearVelocity, maxVelocity);
        }

        if (ballRb.linearVelocity.magnitude < minVelocity)
        {
            if (ballRb.linearVelocityY < 0)
            {
                ballRb.linearVelocityY = -minVelocity;
            }
            else if (ballRb.linearVelocityY > 0)
            {
                ballRb.linearVelocityY = minVelocity;
            }
        }

        if (transform.position.y <= deathPlaneY)
        {
            
            if (!isDead)
                StartCoroutine("DeathAfterDelay");
            
        }
        
        
    }

    public IEnumerator DeathAfterDelay()
    {
        isDead = true;
        animator.SetBool("IsDead", true);
        ballRb.linearVelocity = Vector2.zero;
        ballRb.bodyType = RigidbodyType2D.Kinematic;
        yield return new WaitForSeconds(deathDelay);
        Destroy(gameObject);
        Application.LoadLevel("GameOver");
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
