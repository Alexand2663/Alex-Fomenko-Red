using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent agent;

    public GameObject codey;
    public GameObject tree;
    public float apple;
    public float currentMin;
    public GameObject currentMinTree;
    public GameObject[] trees;
 
    // Start is called before the first frame update
    private void Start()
    {
        currentMin = Mathf.Infinity;
        currentMinTree = null;
        trees = GameObject.FindGameObjectsWithTag("Obstacle");
        codey = GameObject.Find("Codey");

        foreach (GameObject tree in trees)
        {
            apple = Vector3.Distance(codey.transform.position, tree.transform.position);

            if (currentMin > apple)
            {
                currentMin = apple;
                currentMinTree = tree;
            }
        }

        goal = GameObject.FindGameObjectWithTag("Obstacle").transform;
        agent = GetComponent<NavMeshAgent>();   
        //agent.destination = goal.position;

        agent.destination = currentMinTree.transform.position;
        Debug.Log(currentMinTree.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
    }
}
