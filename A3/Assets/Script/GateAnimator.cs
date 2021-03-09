using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateAnimator : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        animator.SetBool("isopen", true);
    }

    public void CloseDoor()
    {
        animator.SetBool("isopen", false);
    }
}
