using UnityEngine;
using UnityEngine.AI;

public class robot : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
