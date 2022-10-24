using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    private List<Vector3> positionList = new List<Vector3>(0);

    [SerializeField] private float force;

    private Vector3 positionMoving;

    private NavMeshAgent agent;

    private Rigidbody rb;


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = (NavMeshAgent)this.GetComponent("NavVeshAgent");
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position == positionMoving)
        {

            positionList.RemoveAt(0);
            pushBall(positionList[0]);
        }
    }
    public void saveCoordinates(Vector3 mousePos)
    {
        positionMoving = mousePos;
        
        if(positionList[0] == null)
        {
            pushBall(mousePos);
        }
        positionList.Add(mousePos);

    }
    
    public void pushBall(Vector3 positionMoving)
    {
        rb.AddForce(positionMoving, ForceMode.Force);
        agent.SetDestination(positionMoving);
    }
}