using UnityEngine;

public class Attacker : PlayerBehavior
{
    private Transform defender;
    public float attackRange = 5f;
    public Transform Defender;

    private void Start()
    {
       
    }

    private void Update()
    {
        base.Update();
        if (Vector3.Distance(transform.position, Defender.position) <= attackRange)
        {
            //Shoot();
            
        }
        else
        {
            agent.SetDestination(Defender.position);
        }
        
    }
}
