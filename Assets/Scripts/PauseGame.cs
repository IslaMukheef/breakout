using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject textOnPause;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textOnPause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!gamePaused)
            {
                Time.timeScale = 0;
                textOnPause.SetActive(true);
                gamePaused = true;
                
            }
            else if (gamePaused)
            {
                Time.timeScale = 1;
                gamePaused = false;
                textOnPause.SetActive(false);
            }
        }
    }
}
