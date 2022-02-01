using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] private Camera camera;
    private RaycastHit hit;
    private string groundTag = "Ground";
    private bool inputEnabled = true;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        if(inputEnabled)HandleInput();
    }

    private void HandleInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag(groundTag))
                {
                    agent.SetDestination(hit.point);
                }
            }
        }
    }

    public void DisableInput()
    {
        inputEnabled = false;
    }
}
