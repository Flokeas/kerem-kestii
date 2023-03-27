using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupspawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] powerup;
    public GameObject player;
    void Start()
    {
        StartCoroutine(spawnpowerup());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator spawnpowerup()
    {
        while (true)
        {
            int powerupindex = Random.Range(0, powerup.Length);
            float randomposx = Random.Range(-10, 10);
            Instantiate(powerup[powerupindex], player.transform.position+new Vector3(randomposx, 8f, 0f), transform.rotation);
            yield return new WaitForSeconds(12);
        }
    }
}
