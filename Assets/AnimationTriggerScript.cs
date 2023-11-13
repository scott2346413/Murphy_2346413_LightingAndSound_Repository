using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerInAnimationTrigger : MonoBehaviour
{
    Animator animator;
    [SerializeField] LookAtConstraint playerLookAt;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("playerNearby", true);
            playerLookAt.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool("playerNearby", false);
            playerLookAt.enabled = false;
        }
    }
}
