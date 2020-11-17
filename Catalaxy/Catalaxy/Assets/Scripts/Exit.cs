using UnityEngine;

public class Exit : MonoBehaviour
{
    void Update()
    {
        ExitPressed();
    }
    public void ExitPressed()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }
}
