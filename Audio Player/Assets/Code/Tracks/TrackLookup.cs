using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrackLookup : MonoBehaviour
{
    public static TrackLookup Instance { get; private set; }
    
    [SerializeField] private List<AudioData> audioDatas;

    private readonly Dictionary<string, AudioClip> lookup = new Dictionary<string, AudioClip>();

    private void Awake()
    {
        Instance = this;
        
        audioDatas.ForEach(audioData =>
        {
            if (lookup.ContainsKey(audioData.Name))
            {
                Debug.LogError($"Tried to add audio data name \"{audioData.Name}\" multiple times");
            }
            else
            {
                lookup[audioData.Name] = audioData.AudioClip;
            }
        });
    }

    public List<string> GetAllTrackNames() => lookup.Keys.ToList();
    
    public bool TryGetAudioClip(string trackName, out AudioClip audioClip) => lookup.TryGetValue(trackName, out audioClip);
}
