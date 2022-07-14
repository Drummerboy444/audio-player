using UnityEngine;

public class EffectGrid : MonoBehaviour
{
    [SerializeField] private EffectController effectControllerPrefab;

    private void Start()
    {
        EffectLookup.Instance.GetAllEffectNames().ForEach(effectName =>
        {
            if (EffectLookup.Instance.TryGetAudioClip(effectName, out AudioClip audioClip))
            {
                Instantiate(effectControllerPrefab, transform).Setup(effectName, audioClip);
            }
            else
            {
                Debug.LogError($"Could not find effect name \"{effectName}\"");
            }
        });
    }
}