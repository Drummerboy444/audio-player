using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrackControllers : MonoBehaviour
{
    public static TrackControllers Instance { get; private set; }
    
    [SerializeField] private TrackController trackControllerPrefab;

    private readonly List<TrackController> trackControllers = new List<TrackController>();

    private void Awake()
    {
        Instance = this;
    }

    public void OnAdd()
    {
        trackControllers.Add(Instantiate(trackControllerPrefab, transform));
    }

    public void OnStopAll()
    {
        trackControllers.ForEach(trackController => trackController.Stop());
    }

    public void Remove(TrackController trackController)
    {
        Destroy(trackController.gameObject);
        trackControllers.Remove(trackController);
    }
}
