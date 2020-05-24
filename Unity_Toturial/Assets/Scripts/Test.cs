using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Test : MonoBehaviour
{
    //Rigidbody myRigid;
    //[SerializeField] private float moveSpeed;

    NavMeshAgent agent;

   // [SerializeField] private Transform[] tf_Destination;
   // private Vector3[] wayPoint;

    private void Start()
    {
        //myRigid = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        
    }

    private void Update()
    {
        Collider[] col = Physics.OverlapSphere(transform.position, 10f);

        if(col.Length >0)
        {
            for(int i = 0; i < col.Length; i++)
            {
                Transform tf_Target = col[i].transform;

                if(tf_Target.name == "Player")
                {
                    NavMeshPath path = new NavMeshPath();
                    agent.CalculatePath(tf_Target.position, path);

                    Vector3[] wayPoints = new Vector3[path.corners.Length + 2];
                    wayPoints[0] = transform.position;
                    wayPoints[wayPoints.Length - 1] = tf_Target.position;

                    float _distance = 0f;
                    for (int p = 0; p < path.corners.Length; p++)
                    {
                        wayPoints[p + 1] = path.corners[p];
                        _distance += Vector3.Distance(wayPoints[p], wayPoints[p + 1]);
                    }

                    if(_distance <= 10f)
                    {
                        agent.SetDestination(tf_Target.position);
                    }

                }
            }
        }

    }

  
}
