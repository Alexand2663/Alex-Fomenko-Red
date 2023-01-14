using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxFeatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 watermelon = new Vector3(-1, 1, 1);

        transform.Rotate(watermelon, Time.deltaTime * 90f);
        /*transform.Rotate(Vector3.forward, Time.deltaTime * 90f);
        transform.Rotate(Vector3.left, Time.deltaTime * 90f);
        transform.Rotate(Vector3.up, Time.deltaTime * 90f);*/
    }

    void watermelon()
    {
        gameObject.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
        Invoke("watermelon", 5f);
    }
}