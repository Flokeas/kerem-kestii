using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    spawnn ABC;


    void Start()
    {
      ABC=player.GetComponent<spawnn>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
       
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            ABC.shieldindicator.SetActive(false);
            ABC.haspowerup3 = false;
        }
    }

}
