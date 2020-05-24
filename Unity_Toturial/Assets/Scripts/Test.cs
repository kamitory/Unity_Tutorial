using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Test : MonoBehaviour
{
    Rigidbody myRigid;
    [SerializeField] private float moveSpeed;

    NavMeshAgent agent;

    [SerializeField] private Transform[] tf_Destination;
    private Vector3[] wayPoint;

    private void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();

        wayPoint = new Vector3[tf_Destination.Length + 1];
        for (int i = 0; i < tf_Destination.Length; i++)
            wayPoint[i] = tf_Destination[i].position;
        wayPoint[wayPoint.Length - 1] = transform.position;
    }

    private void Update()
    {
        Patrol();
        //if(Input.GetKeyDown(KeyCode.W))
        //{
        //    agent.SetDestination(tf_Destination.position);
        //}
    }

    private void Patrol()
    {
        for (int i = 0; i < wayPoint.Length; i++)
        {
            if(Vector3.Distance(transform.position, wayPoint[i]) <= 0.1f)
            {
                if(i != wayPoint.Length -1)
                agent.SetDestination(wayPoint[i + 1]);
                else
                agent.SetDestination(wayPoint[0]);
            }
        }
    }
}
