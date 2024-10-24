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

    public void OnMouseDown()
    {
        animator.SetInteger("Mushroom_Idle", animationVariable);
        animator.SetInteger("Mushroom_Jump", animationVariable);
        animator.SetInteger("Mushroom_Attacked", animationVariable);
        animationVariable++;
        if (animationVariable == 3) animationVariable = 0;
        // �� ��ȣ�� �ű�� ������ ��ȣ�� �ٲ㼭 �θ���
        // animationVariable�� ����
    }
}