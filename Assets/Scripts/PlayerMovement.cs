using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    public float rotateSpeedMovement = 0.1f;
    float rotateVelocity;

    private void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();

        agent.speed = 3.4f;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);

                Quaternion rotationToLockAt = Quaternion.LookRotation(hit.point - transform.position);
                float rotationY = Mathf.SmoothDampAngle(transform.eulerAngles.y, rotationToLockAt.eulerAngles.y, ref rotateVelocity, rotateSpeedMovement * (Time.deltaTime * 10));

                transform.eulerAngles = new Vector3(0, rotationY, 0);
            }
        }
    }
}
