using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemainingThrows : MonoBehaviour
{
    public int remainingThrows;

    // Start is called before the first frame update
    void Start()
    {
        remainingThrows = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            remainingThrows -= 1;
        }
    }
}
