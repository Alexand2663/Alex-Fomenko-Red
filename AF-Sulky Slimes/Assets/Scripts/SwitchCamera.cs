using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class SwitchCamera : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    // Start is called before the first frame update
    void Start()
    {
        //cam2 = gameObject.GetComponent<Camera>();
        cam1.enabled = true;
        cam2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cam1.enabled = true;
            cam2.enabled = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "stack")
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }
    }
}