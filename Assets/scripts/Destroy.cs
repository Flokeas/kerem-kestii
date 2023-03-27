using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
     public bool gameover;
    public TextMeshProUGUI gameovertext;
    public Button restartbutton;
    public GameObject startbutton;
    public bool gameactive;
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other) 
    {
        
        if (other.CompareTag("bullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Player"))
        {
            
            gameover = true;
            Debug.Log("GameOver");
            gameovertext.gameObject.SetActive(true);
            restartbutton.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
       
    }
 
	public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

	public void StartGame()
    {
        gameactive = true;
        startbutton.gameObject.SetActive(false);
    }


}
