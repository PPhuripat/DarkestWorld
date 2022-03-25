using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class actionout : MonoBehaviour
{
    public PlayerMovement player;
    [SerializeField] private GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<PlayerMovement>();
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        show();
    }
    public void show() {
        if(player.act <= 0){
            panel.SetActive(true);
        }
    }
}
