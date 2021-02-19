using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator animator;
    private string currentState;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void ChangeAnimationState(string newState)
    {
        // stop the same animation from interrupting itself
        if (currentState == newState) return;

        // play the animation
        animator.Play(newState);

        // reassign the current state
        currentState = newState;
    }
}
