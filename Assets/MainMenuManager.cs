using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    Scene scene;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
