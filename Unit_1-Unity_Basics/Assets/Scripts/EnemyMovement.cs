using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;

    private Animator anim;


    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
        if (anim)
            anim.SetFloat("Speed_f", navMeshAgent.speed);
    }

    private void Update()
    {
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
            

        }
    }



}
