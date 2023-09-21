using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{

    public Animator animator
    int isWalkingHash, isRunningHash

    void Start()
    {
        isWalkingHash = animator.StringToHash("isWalking")
        isRunningHash = animator.StringToHash("isRunning")
    }

    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("W")
        bool runPressed = Input.GetKey("left shift")

        if (!isWalking && forwardPressed ! runPressed)
        {
            animator.SetBool("isWalking", true)
        }
        
        if (isWalking && ! runPressed && ! forwardPressed)
        {
            animator.SetBool("isWalking", false)
        }

        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool("isRunning", true)
        }

        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning", false)
        }

    }
    
}
