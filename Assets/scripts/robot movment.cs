using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class robotMovment : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] NavMeshAgent agent;
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        UpdateAnimations();
        agent.SetDestination(target.position);
    }

    void UpdateAnimations()
    {

        bool isMoving = agent.velocity.magnitude > 0.1f;
        anim.SetBool("Walk_Anim", isMoving);


    }

}