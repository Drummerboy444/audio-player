using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrackControllers : MonoBehaviour
{
    [SerializeField] private TrackController trackControllerPrefab;

    private readonly List<TrackController> trackControllers = new List<TrackController>();

    public void OnAdd()
    {
        trackControllers.Add(Instantiate(trackControllerPrefab, transform));
    }

    public void OnRemove()
    {
        if (trackControllers.Count == 0) return;

        TrackController trackController = trackControllers.Last();
        Destroy(trackController.gameObject);
        trackControllers.Remove(trackController);
    }
}
