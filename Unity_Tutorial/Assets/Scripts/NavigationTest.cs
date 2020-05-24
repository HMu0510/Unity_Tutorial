using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationTest : MonoBehaviour
{
    Rigidbody myRigid;
    [SerializeField] private float moveSpeed;

    NavMeshAgent agent;

    [SerializeField] private Transform tf_Destination;
    private Vector3 originPos;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        myRigid = GetComponent<Rigidbody>();
        originPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.W))
        //{
        //    agent.SetDestination(tf_Destination.position);
        //    //myRigid.MovePosition(this.transform.position + transform.forward * moveSpeed * Time.deltaTime);
        //}
        Patrol();
    }

    private void Patrol()
    {
        if (Vector3.Distance(transform.position, tf_Destination.position) < 0.1f)
        {
            agent.SetDestination(originPos);
        }
        if (Vector3.Distance(transform.position, originPos) < 0.1f)
        {
            agent.SetDestination(tf_Destination.position);
        }
    }
}
