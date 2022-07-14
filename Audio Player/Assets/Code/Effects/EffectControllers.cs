using UnityEngine;
using UnityEngine.UI;

public class EffectControllers : MonoBehaviour
{
    public static EffectControllers Instance { get; private set; }
    
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Slider slider;

    private void Awake()
    {
        Instance = this;
    }

    public void OnSliderValueChanged()
    {
        audioSource.volume = slider.value;
    }

    public void Play(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
