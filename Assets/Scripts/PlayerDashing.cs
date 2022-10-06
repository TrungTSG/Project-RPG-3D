using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerDashing : MonoBehaviour
{
    public float speedDash;
    NavMeshAgent agent;
    bool isDashing;

    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isDashing = true;
        }
    }

    private void FixedUpdate()
    {
        if (isDashing)
            Dash();
    }

    void Dash()
    {
        agent.stoppingDistance = 0;
        agent.Move(transform.forward * speedDash);
        isDashing = false;
    }
}
