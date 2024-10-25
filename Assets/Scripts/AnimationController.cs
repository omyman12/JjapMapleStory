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

    public void OnMouseDown()
    {
        animationVariable = animationVariable % 3;
        animator.SetInteger("Mushroom_Idle", animationVariable);
        animator.SetInteger("Mushroom_Jump", animationVariable);
        animator.SetInteger("Mushroom_Attacked", animationVariable);
        animationVariable++;


        // 각 번호를 매기고 누르면 번호를 바꿔서 부르게
        // animationVariable을 수정
    }
}