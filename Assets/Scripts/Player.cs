using UnityEngine;

public class Player : MonoBehaviour
{

    private float roofLimit = 4.5f;
    private float boundryLimit = 7.4f;
    private float speed = 1.4f;
    public Rigidbody2D ballRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
