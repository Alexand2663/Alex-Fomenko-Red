using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeyToNearestTree : MonoBehaviour
{
    public GameObject codey;
    public GameObject tree;
    public float apple;
    public float currentMin;

    public GameObject[] trees;

    public float distanceBetweenObjects;

    // Start is called before the first frame update
    void Start()
    {
        trees = GameObject.FindGameObjectsWithTag("Obstacle");

        foreach (GameObject tree in trees)
        {
            apple = Vector3.Distance(codey.transform.position, tree.transform.position);
            Debug.Log(apple);

            if (currentMin > apple)
            {
                currentMin = apple;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        distanceBetweenObjects = Vector3.Distance(transform.position, tree.transform.position);
    }
}
