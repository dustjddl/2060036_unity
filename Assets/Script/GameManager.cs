using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        // Ÿ��Ʋ ���� ���: ���콺 Ŭ�� �� �޴� ������ ��ȯ
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