using UnityEngine;
using UnityEngine.AI;

public class sa3edai : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent agent;
    Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Set destination
        agent.SetDestination(target.position);

        // Get speed (magnitude of velocity)
        float speed = agent.velocity.magnitude;

        // Set "run" parameter in Animator (true if moving)
        animator.SetBool("run", speed > 0.1f);
    }
}
