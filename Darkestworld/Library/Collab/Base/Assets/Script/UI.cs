using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    private int next;
    [SerializeField] private GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        next = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Startbutton() {

        SceneManager.LoadScene(next);
    }
}
