using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startbutton : MonoBehaviour
{
    // Start is called before the first frame update
    private Button button;
    Destroy destroyy;
    public GameObject enemy;
    void Start()
    {
        button = GetComponent<Button>();
        destroyy = enemy.GetComponent<Destroy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void start()
    {
        destroyy.StartGame();
    }
}
