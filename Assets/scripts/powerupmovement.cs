using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupmovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,-1,0)*Time.deltaTime*speed);
    }
}
