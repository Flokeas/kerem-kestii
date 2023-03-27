using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class enemyspawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
     int enemycount;
    public int wavecount = 3;
    public spawnn bullets;
    public GameObject player;
    Destroy destroyy;
    public GameObject enemyclon;
    

    void Start()
    {
        destroyy = enemy.GetComponent<Destroy>();
        bullets =player.GetComponent<spawnn>();
        if (destroyy.gameactive == true)
        {
            spawnenemy();
        }
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
        enemycount = FindObjectsOfType<enemycontrol>().Length;
        if (enemycount==1)
        {
            for (int i = 0; i < wavecount; i++)
            {
                if (destroyy.gameactive ==true)
                {
                    spawnenemy();
                    
                }

            }
            if (destroyy.gameactive == true)
            {
                wavecount = wavecount + 1;
                bullets.bulletcount = bullets.bulletcount + wavecount + 5;
            }
           
        }
        
    }
   

   
   
    public void spawnenemy()
    {
        float radius = 15f;
        Vector3 randomPos = Random.insideUnitSphere * radius;
        randomPos += transform.position;
        randomPos.y = 0f;

        Vector3 direction = randomPos - transform.position;
        direction.Normalize();

        float dotProduct = Vector3.Dot(transform.forward, direction);
        float dotProductAngle = Mathf.Acos(dotProduct / transform.forward.magnitude * direction.magnitude);

        randomPos.x = Mathf.Cos(dotProductAngle) * radius + transform.position.x;
        randomPos.y = Mathf.Sin(dotProductAngle * (Random.value > 0.5f ? 1f : -1f)) * radius + transform.position.y;
        randomPos.z = transform.position.z;
       enemyclon= Instantiate(enemy
               , (player.transform.position+randomPos), Quaternion.identity);
       
    }
    


}

    

