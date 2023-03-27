using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakecontrol : MonoBehaviour
{
    // Start is called before the first frame update

    
    public float speed;
    public float rotationspeed;
    spawnn rotation;
    public GameObject player;
    public GameObject cameraa;
    public Rigidbody2D playerrb;
    public GameObject focalpoint;
    public GameObject flames;
    public GameObject enemy;
    Destroy destroyy;
    

    void Start()
    {
        rotation=player.GetComponent<spawnn>();
        playerrb = player.GetComponent<Rigidbody2D>();
        destroyy= GameObject.FindWithTag("Enemy").GetComponent<Destroy>();
    }

    // Update is called once per frame
    void Update()
    {

        float vertical = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.W)&&destroyy.gameover==false&& destroyy.gameactive == true)
        {
            playerrb.AddForce(focalpoint.transform.right * speed * Time.deltaTime * vertical);
            flames.SetActive(true);
        }
        else
        {
            flames.SetActive(false);
        }
        
            
        
       
        float horizontal = Input.GetAxis("Horizontal");
       
        
            
             
      
       
            transform.Rotate(new Vector3(0, 0, -1) * rotationspeed * Time.deltaTime*horizontal);
        if (rotation.haspowerup2 == true && destroyy.gameover == false&& destroyy.gameactive == true)
        {
            rotationspeed = 200;
            speed = 7;
        }
        else
        {
            rotationspeed = 100;
            speed = 4;
        }


        cameraa.transform.position = player.transform.position + new Vector3(0, 0, -10);
       

    }
  
    
}
