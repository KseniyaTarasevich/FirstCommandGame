using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] Button exitButton;

    void Start()
    {
        Button startBtn = startButton.GetComponent<Button>();
        Button exitBtn = exitButton.GetComponent<Button>();

        startBtn.onClick.AddListener(PlayPressed);
        exitBtn.onClick.AddListener(ExitPressed);
    }

    public void PlayPressed()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}

