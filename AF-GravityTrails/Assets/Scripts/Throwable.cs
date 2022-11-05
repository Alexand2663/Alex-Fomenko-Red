using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public int throwableCounter;
    public GameObject objectThrown;
    public Vector3 offset;
    public Text collectibleCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {    
            offset = new Vector3(10, 0, 0);
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Vector3 throwablePosition = transform.position + offset;

            if (throwableCounter > 0)
            {
                Instantiate(objectThrown, throwablePosition, transform.rotation);
                throwableCounter -= 1;
                collectibleCounter.text = throwableCounter.ToString();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            throwableCounter++;
            collectibleCounter.text = throwableCounter.ToString();
            Destroy(collision.gameObject);
        }
    }
}
