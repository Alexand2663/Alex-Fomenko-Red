using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject enemy;
    public float xForce;
    public float yForce;
    public float xDirection;
    private Rigidbody2D enemyRigidBody;
    public Teleport teleport;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }

        if (collision.gameObject.tag == "Collectible")
        {

            Destroy(collision.gameObject);
            
            Destroy(enemy);
            
            teleport.enemyCount-- ;
            Debug.Log(collision.gameObject.name);
            Debug.Log("Destroyed");
        }
    }

    private void FixedUpdate()
    {
        if (transform.position.x <= -8)
        {
            xDirection = 1;
            enemyRigidBody.AddForce(Vector2.right * xForce);
        }
        if (transform.position.x >= 8)
        {
            xDirection = -1;
            enemyRigidBody.AddForce(Vector2.left * xForce);
        }
    }
}
