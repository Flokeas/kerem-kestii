using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class gameoverr : MonoBehaviour
{
    // Start is called before the first frame update
    Destroy destroyy;
    
   
    public TextMeshProUGUI gameovertext;
    
    void Start()
    {
        destroyy=GameObject.FindWithTag("Enemy").GetComponent<Destroy>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyy.gameover == true)
        {
            gameovertext.gameObject.SetActive(true);
        }
    }
}
