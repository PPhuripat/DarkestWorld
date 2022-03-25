using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    [SerializeField] private string StartGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Startbutton() {

        SceneManager.LoadScene(StartGame);
        Debug.Log("starting");
    }

    public void button1()
	{
        Debug.Log("000");
	}
}
