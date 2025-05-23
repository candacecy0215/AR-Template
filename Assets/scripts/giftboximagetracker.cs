using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class giftboximagetracker : MonoBehaviour
{
        [SerializeField]
ARTrackedImageManager m_TrackedImageManager;

public GameObject giftboxPrefab;

void OnEnable() => m_TrackedImageManager.trackedImagesChanged += OnChanged;

void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
{
    foreach (var newImage in eventArgs.added)
    {
        // Handle added event
        GameObject newObject = GameObject.Instantiate(giftboxPrefab);
        newObject.transform.SetParent(newImage.transform, false);
    }

    foreach (var updatedImage in eventArgs.updated)
    {
        // Handle updated event
    }

    foreach (var removedImage in eventArgs.removed)
    {
        // Handle removed event
    }
}
}
