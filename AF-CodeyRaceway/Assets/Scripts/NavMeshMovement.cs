using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    private void Start()
    {
        goal = GameObject.FindGameObjectWithTag("Obstacle").transform;
        agent = GetComponent<NavMeshAgent>();   
        agent.destination = goal.position;
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
