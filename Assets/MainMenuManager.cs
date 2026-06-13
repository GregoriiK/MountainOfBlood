using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class MainMenuManager : MonoBehaviour
{
    Scene scene;
    AudioManager audioManager;
    [SerializeField] GameObject optionsPanel;
    public float mainVolumeBackup;
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        audioManager = FindAnyObjectByType<AudioManager>();
        mainVolumeBackup = audioManager.mainAudioSource.volume;
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
            mainVolumeBackup = audioManager.mainAudioSource.volume;
        }
        else
        {
            optionsPanel.SetActive(true);
        }
    }

    public void CancelChanges()
    {
        audioManager.mainVolumeSlider.value = mainVolumeBackup;
        audioManager.ChangeVolume();
        ToggleOptionsPanel() ;
    }
}
