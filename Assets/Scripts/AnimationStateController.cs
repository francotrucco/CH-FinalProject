using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            animator.SetBool(isWalkingHash, true);
        } 
        if (context.canceled)
        {
            animator.SetBool(isWalkingHash, false);
        }
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            animator.SetBool(isRunningHash, true);
        } 
        
        if (context.canceled)
        {
            animator.SetBool(isRunningHash, false);
        }

    }
}
