using UnityEngine;

public class StartTheGame : MonoBehaviour
{
    public bool gameOver = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameOver = false;
            Application.LoadLevel("Main");
        }
    }
    
}
