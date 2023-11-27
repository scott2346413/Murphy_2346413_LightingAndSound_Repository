using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerInAnimationTrigger : MonoBehaviour
{
    Animator animator;
    bool playerNearby;

    [SerializeField] LookAtConstraint playerLookAt;

    private void Start()
    {
        animator = GetComponent<Animator>();
        playerLookAt.weight = 0f;
    }

    private void Update()
    {
        float lerpTowards = 0;

        if (playerNearby)
        {
            lerpTowards = 1;
        }

        playerLookAt.weight = Mathf.Lerp(playerLookAt.weight, lerpTowards, Time.deltaTime*3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("playerNearby", true);
            playerNearby = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool("playerNearby", false);
            playerNearby = false;
        }
    }
}
