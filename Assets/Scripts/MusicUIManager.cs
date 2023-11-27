using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicUIManager : MonoBehaviour
{
    [SerializeField] musicOption[] musicOptions;
    [SerializeField] float offsetBetweenImages;

    [SerializeField] GameObject upButton;
    [SerializeField] GameObject downButton;
    [SerializeField] UnityEngine.UI.Slider volumeSlider;

    int activeAudio = 0;

    // Start is called before the first frame update
    void Start()
    {

        float currentOffset = 0;

        foreach(musicOption option in musicOptions)
        {
            Vector3 startPosition = new Vector3(0, currentOffset, 0);
            option.targetPosition = startPosition;
            option.transform.localPosition = startPosition;
            currentOffset -= offsetBetweenImages;
        }

        updateAudioSources();
        updateButtonsActive();
    }

    void updateAudioSources()
    {
        foreach (musicOption option in musicOptions)
        {
            option.audioSource.SetActive(false);
        }

        musicOptions[activeAudio].audioSource.SetActive(true);
    }

    void updateButtonsActive()
    {
        upButton.SetActive(activeAudio > 0);
        downButton.SetActive(activeAudio < musicOptions.Length-1);
    }

    public void moveDown()
    {
        activeAudio++;

        foreach(musicOption option in musicOptions)
        {
            option.targetPosition += new Vector3(0, offsetBetweenImages, 0);
        }

        updateAudioSources();
        updateButtonsActive();
    }

    public void moveUp()
    {
        activeAudio--;

        foreach(musicOption option in musicOptions)
        {
            option.targetPosition -= new Vector3(0, offsetBetweenImages, 0);
        }

        updateAudioSources();
        updateButtonsActive();
    }

    public void updateVolume()
    {
        foreach(musicOption option in musicOptions)
        {
            option.audioSource.GetComponent<AudioSource>().volume = volumeSlider.value;
        }
    }

    
}
