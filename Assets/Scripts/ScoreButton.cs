using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{

    //��������Ʈ ���帮����
    [SerializeField] Button scoreButton;
    public int score;
    public ScoreText scoreText;
    public Action<int> OnScoreChanged;
    AnimationController animationController;

    // ��Ʈ�� �����̽����ϸ� �ڵ��ϼ�
    private void Awake()
    {
        animationController = FindObjectOfType<AnimationController>();
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(animationController.OnMouseDown);
        scoreButton.onClick.AddListener(PointUp);
    }

    void PointUp()
    {
        score++;
        OnScoreChanged?.Invoke(score);
    }

}
//��������Ʈ = �����Ǵ�
// ��ũ�� �����ϸ� ��ǥ����, ����, ���ϸ��̼��� ����ϴ°� ��ũ�� ��� ���־�
//Ʈ���Ÿ� �ߵ��ؼ� �κ�ũ�ϸ� ���̽���ǰ� �����ش�