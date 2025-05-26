using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        // 타이틀 씬일 경우: 마우스 클릭 시 메뉴 씬으로 전환
        if (SceneManager.GetActiveScene().name == "TitleScene" && Input.GetMouseButtonDown(0))
        {
            LoadMenuScene();
        }
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}