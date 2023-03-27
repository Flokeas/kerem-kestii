using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spawnn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bullets;
    public GameObject playerr;
    public bool haspowerup2;
    public bool haspowerup3;
    public bool haspowerup1;
    public GameObject bulletprojectile;
    public GameObject bullerprojectile1;
    public GameObject bullerprojectile2;
    public GameObject shieldindicator;
    public float bulletcount = 25;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI scoretext2;
    public enemyspawn forwave;
    public GameObject ENEMYSPAWN;
    public GameObject clonebullets;
    
  
    
    void Start()
    {
       forwave=ENEMYSPAWN.GetComponent<enemyspawn>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space)&&haspowerup1==false&&bulletcount>0)
        {
            
            clonebullets =Instantiate(bullets, playerr.transform.position,bulletprojectile.transform.rotation);
            bulletcount = bulletcount - 1;
            

        }
        if (Input.GetKeyDown(KeyCode.Space)&& haspowerup1==true&&bulletcount>0) 
        {
            clonebullets = Instantiate(bullets, playerr.transform.position, bulletprojectile.transform.rotation);
           
            clonebullets = Instantiate(bullets, bullerprojectile1.transform.position, bullerprojectile1.transform.rotation);
            
            clonebullets = Instantiate(bullets, bullerprojectile2.transform.position, bullerprojectile2.transform.rotation);
            
            bulletcount = bulletcount - 1;
            
        }
        if (haspowerup3 == true)
        {
            shieldindicator.SetActive(true);
        }
        
        scoretext.text = "bullets: " + bulletcount;
        scoretext2.text = "wave: " + (forwave.wavecount - 3);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("powerup1"))
        {
            haspowerup1 = true;
            Destroy(other.gameObject);

            StartCoroutine(powerupcountdown());

        }
        if (other.CompareTag("powerup2"))
        {
            haspowerup2 = true;
            Destroy(other.gameObject);
            StartCoroutine(powerupcountdown());
        }
        if (other.CompareTag("powerup3"))
        {
            haspowerup3 = true;
            Destroy(other.gameObject) ;
            StartCoroutine(powerupcountdown());
        }
    }
    IEnumerator powerupcountdown()
    {
        yield return new WaitForSeconds(5);
        haspowerup1 = false;
        haspowerup2 = false;
        haspowerup3 = false;
    }
    
}

