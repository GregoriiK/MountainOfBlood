using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class MainMenuManager : MonoBehaviour
{
    Scene scene;
    [SerializeField] GameObject optionsPanel;
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        ToggleOptionsPanel();
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ToggleOptionsPanel()
    {
        if (optionsPanel.activeInHierarchy == true)
        {
            optionsPanel.SetActive(false);
        }
        else
        {
            optionsPanel.SetActive(true);
        }
    }

}
