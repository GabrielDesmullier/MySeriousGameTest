using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator doorAnimator;
    private GameManager gameManager;

    private void Awake()
    {
        doorAnimator = GetComponent<Animator>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&&gameManager.hasKey)
        {
            doorAnimator.SetTrigger("OpenDoor");
        }
    }
}
