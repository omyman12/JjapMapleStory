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

    void SetanimationVariable()
    {
        animator.SetInteger("Mushroom_Idle", animationVariable);
        animator.SetInteger("Mushroom_Jump", animationVariable = 1);
        animator.SetInteger("Mushroom_Attacked", animationVariable = 2);
    }
    void OnMouseDown()
    {
        // �� ��ȣ�� �ű�� ������ ��ȣ�� �ٲ㼭 �θ���
        // animationVariable�� ����
      
    }
}