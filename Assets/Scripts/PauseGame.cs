using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject textOnPause;
    public GameObject buttonOnPause;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textOnPause.SetActive(false);
        buttonOnPause.SetActive(false);
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
                buttonOnPause.SetActive(true);
                gamePaused = true;
                
            }
            else if (gamePaused)
            {
                Time.timeScale = 1;
                gamePaused = false;
                textOnPause.SetActive(false);
                buttonOnPause.SetActive(false);
            }
        }
    }

    public void QuitGame()    {
        Debug.Log("Quit Game");
            Application.Quit();
        }
}
