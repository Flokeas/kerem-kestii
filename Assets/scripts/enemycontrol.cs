using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class enemycontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D enemyrb;
    private Transform player1;
    public Transform target;



    void Start()
    {
        enemyrb= GetComponent<Rigidbody2D>();
        player1 = GameObject.FindWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player1.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);
        transform.Translate(Vector3.right*speed*Time.deltaTime);
        RotateTowardsTarget();


    }
    private void RotateTowardsTarget()
    {
        var offset = -90f;
        Vector2 direction = target.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));
    }
}
