using System;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float speed =8f;
    public float horizontalInput;

    private float limitBound = 7.3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -limitBound)
        {
            transform.position = new Vector3(-limitBound, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > limitBound)
        {
            transform.position = new Vector3(limitBound, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
    

    
}
