using UnityEngine;
using UnityEngine.AI;

public class PlayerBehavior : MonoBehaviour
{
    protected bool isHiding;
    protected NavMeshAgent agent;

    protected virtual void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    protected void SetDestination(Vector3 destination)
    {
        agent.SetDestination(destination);
    }

    protected virtual void Update()
    {
        
    }
}
