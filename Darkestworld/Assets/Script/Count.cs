using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    [SerializeField] private Text textact;
    [SerializeField] private GameObject panel;
    public PlayerMovement count;
    // Start is called before the first frame update
    void Start()
    {
        count = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAct();
    }

    public void UpdateAct() {
        textact.text = count.act.ToString();
    }
}


