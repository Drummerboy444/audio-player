using UnityEngine;
using UnityEngine.UI;

public class EffectController : MonoBehaviour
{
    [SerializeField] private Text text;

    private AudioClip audioClip;

    public void OnButtonClicked()
    {
        EffectControllers.Instance.Play(audioClip);
    }

    public void Setup(string name, AudioClip audioClip)
    {
        text.text = name;
        this.audioClip = audioClip;
    }
}
