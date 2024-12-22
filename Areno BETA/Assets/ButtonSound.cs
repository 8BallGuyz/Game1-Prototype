using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public AudioSource buttonAudioSource;

    void Start()
    {
        // Add a listener to the button to play sound on click
        Button button = GetComponent<Button>();
        button.onClick.AddListener(PlayButtonSound);
    }

    void PlayButtonSound()
    {
        buttonAudioSource.Play();
    }
}
