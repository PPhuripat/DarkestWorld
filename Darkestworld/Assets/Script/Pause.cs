using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    [SerializeField] public string StartGame = "0";
    [SerializeField] private GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pauseGame();
    }
    public void pauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            showMenu();
        }
    }
    public void showMenu()
    {
     
        panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void hideMenu()
    {
     
        panel.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void Menubutton()
    {
        SceneManager.LoadScene(StartGame);
    }
}
