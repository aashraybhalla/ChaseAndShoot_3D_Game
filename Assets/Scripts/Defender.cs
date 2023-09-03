using UnityEngine;
using UnityEngine.AI;

public class Defender : MonoBehaviour
{
    public Transform[] hidingSpots;
    public float hideDuration = 1f;
    private bool isHiding;

    private NavMeshAgent agent;

    private int currentHidingSpotIndex;

    private void Start()
    {
        currentHidingSpotIndex = Random.Range(0, hidingSpots.Length);
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(hidingSpots[currentHidingSpotIndex].position);
    }

    private void Update()
    {

        if (!isHiding)
        {
            isHiding = true;
            Invoke("EndHide", hideDuration);
        }
        
    }

    private void EndHide()
    {
        isHiding = false;
        currentHidingSpotIndex++;
        if (currentHidingSpotIndex >= hidingSpots.Length)
        {
            currentHidingSpotIndex = 0;
        }
        agent.SetDestination(hidingSpots[currentHidingSpotIndex].position);
    }
}
