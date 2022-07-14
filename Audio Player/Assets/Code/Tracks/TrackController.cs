using UnityEngine;
using UnityEngine.UI;

public class TrackController : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Dropdown dropdown;

    private void Start()
    {
        dropdown.AddOptions(TrackLookup.Instance.GetAllTrackNames());
        TryPlayDropdownTrack();
    }

    public void OnSliderValueChanged()
    {
        audioSource.volume = slider.value;
    }

    public void OnDropdownValueChanged()
    {
        TryPlayDropdownTrack();
    }

    private void TryPlayDropdownTrack()
    {
        string trackName = dropdown.GetValue();

        if (TrackLookup.Instance.TryGetAudioClip(trackName, out AudioClip audioClip))
        {
            PlayAudioClip(audioClip);
        }
        else
        {
            Debug.LogError($"Could not find audio clip \"{trackName}\"");
        }
    }

    private void PlayAudioClip(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
