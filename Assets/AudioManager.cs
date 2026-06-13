using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AudioManager : MonoBehaviour
{
    [SerializeField] public Slider mainVolumeSlider;
    [SerializeField] TextMeshProUGUI mainVolumeText;
    public AudioSource mainAudioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainAudioSource = GetComponent<AudioSource>();
        ChangeVolume();
    }

    public void ChangeVolume()
    {
        mainAudioSource.volume = mainVolumeSlider.value;
        mainVolumeText.text = $"{Mathf.Floor(mainVolumeSlider.value*100)}%";
    }

}
