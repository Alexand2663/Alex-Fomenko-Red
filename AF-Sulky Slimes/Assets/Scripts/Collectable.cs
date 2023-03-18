using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float distanceToMove;

    private Vector3 startingPosition;
    private Vector3 endingPosition;

    public float speed = 0.1f;
    public float direction = -1f;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        //endingPosition = new Vector3(48.33f, 60+distanceToMove, 58);
        endingPosition = new Vector3(0, distanceToMove, 0) + startingPosition;
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y > 110)
        {
            direction = 1;
        }
        else if (transform.position.y < 60)
        {
            direction = -1;
        }
    }
}
