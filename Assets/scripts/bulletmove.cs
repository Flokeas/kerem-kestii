using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private GameObject player;
    
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right* speed * Time.deltaTime);

        
        float distance = Vector3.Distance(player.transform.position, gameObject.transform.position);
        if (distance>20f)
        {
            Destroy(gameObject);
        }
    }
}
