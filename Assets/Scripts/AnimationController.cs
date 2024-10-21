using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator animator;

    // _animator 세팅 
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void SetanimationVariable()
    {
        animator.SetInteger("Mushroom_Idle", animationVariable);
        animator.SetInteger("Mushroom_Jump", animationVariable = 1);
        animator.SetInteger("Mushroom_Attacked", animationVariable = 2);
    }
    void OnMouseDown()
    {
        // 각 번호를 매기고 누르면 번호를 바꿔서 부르게
        // animationVariable을 수정
      
    }
}