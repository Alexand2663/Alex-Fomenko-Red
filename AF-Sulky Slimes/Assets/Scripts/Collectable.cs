using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float distanceToMove = 50;

    private Vector3 startingPosition;
    private Vector3 endingPosition;

    public float speed = 0.1f;
    public float direction = -1f;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        endingPosition = startingPosition + new Vector3(distanceToMove, 0, 0);
        //endingPosition = new Vector3(0, distanceToMove, 0) + startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= startingPosition.x)
        {
            direction = 1;
        }
        else if (transform.position.x >= endingPosition.x)
        {
            direction = -1;
        }

        startingPosition.x += speed * direction * Time.deltaTime;
    }
}
