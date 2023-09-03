using UnityEngine;
using UnityEngine.AI;

public class Attacker : MonoBehaviour
{
    public float attackRange = 2f;

    //private NavMeshAgent agent;
    //[SerializeField] private float AttackerSpeed = 3f;

    public Transform target;

    private void Start()
    {
        //agent = GetComponent<NavMeshAgent>();
        //agent.speed = AttackerSpeed;
    }

    private void Update()
    {
        //ChaseTarget();
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(0, 0, vertical * Time.deltaTime * 4));
        transform.Rotate(new Vector3(0, horizontal * Time.deltaTime * 100, 0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastShooting();
        }


    }

    public void RaycastShooting()
    {
        Physics.Raycast(transform.position, target.position);
        Debug.Log("Shooting");
    }

    public void ChaseTarget()
    {
       // agent.SetDestination(target.position);
    }

    void MovePlayer()
    {
        

    }


}
