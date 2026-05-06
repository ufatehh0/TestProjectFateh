using UnityEngine;
using UnityEngine.AI; 

public class AIBrain : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public Transform[] patrolPoints; 

    public float detectRange = 8f; 
    private int currentPointIndex = 0;

    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();

       
        GoToNextPoint();
    }

    void Update()
    {
        
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer < detectRange)
        {
            
            agent.SetDestination(player.position);
        }
        else
        {
            
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                GoToNextPoint();
            }
        }
    }

    void GoToNextPoint()
    {
        if (patrolPoints.Length == 0) return;

        
        agent.destination = patrolPoints[currentPointIndex].position;

        
        currentPointIndex = (currentPointIndex + 1) % patrolPoints.Length;
    }
}