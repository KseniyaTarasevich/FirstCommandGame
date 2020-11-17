using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LoseScene : MonoBehaviour
{


    [SerializeField] Button retryButton;
    [SerializeField] Button exitButton;

    void Start()
    {
        Button startBtn = retryButton.GetComponent<Button>();
        Button exitBtn = exitButton.GetComponent<Button>();

        startBtn.onClick.AddListener(RetryPressed);
        exitBtn.onClick.AddListener(ExitToMenuPressed);
    }

    public void RetryPressed()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitToMenuPressed()
    {
        SceneManager.LoadScene("Menu");
    }
}
