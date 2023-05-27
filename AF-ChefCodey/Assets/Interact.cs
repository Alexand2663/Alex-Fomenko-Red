using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public string triggerName = "";

    public GameObject platePrefab;
    public GameObject heldItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (triggerName == "Plate1")
            {
                heldItem = Instantiate(platePrefab, transform, false);
            }

            if (triggerName == "Plate2")
            {
                heldItem = Instantiate(platePrefab, transform, false);
            }

            if (triggerName == "Plate3")
            {
                heldItem = Instantiate(platePrefab, transform, false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }
}
