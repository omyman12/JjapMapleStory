using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{

    //델리게이트 에드리스너
    [SerializeField] Button scoreButton;
    public int score;
    public ScoreText scoreText;
    public Action<int> OnScoreChanged;
    AnimationController animationController;

    // 컨트롤 스페이스바하면 자동완성
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
//델리게이트 = 레시피다
// 워크를 실행하면 좌표변경, 사운드, 에니메이션을 재생하는걸 워크에 묶어서 ㅇ넣어
//트리거를 발동해서 인보크하면 같이실행되게 도와준다