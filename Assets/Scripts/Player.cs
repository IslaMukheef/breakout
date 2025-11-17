using UnityEngine;

public class Player : MonoBehaviour
{

   
    public Rigidbody2D ballRb;
    public float maxVelocity;
    public float minVelocity;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        
    }

    
    


   
}
