using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator animator;

    // _animator ���� 
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        // animationVariable�� ����
        animator.SetInt("Mushroom_Idle", animationVariable);
        animator.
    }
}