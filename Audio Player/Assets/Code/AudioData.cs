using System;
using UnityEngine;

[Serializable]
public class AudioData
{
    [SerializeField] private AudioClip audioClip;
    public AudioClip AudioClip => audioClip;

    [SerializeField] private string name;
    public string Name => name;
}
