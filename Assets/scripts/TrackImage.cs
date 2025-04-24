using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation; // include xr library

public class TrackImage : MonoBehaviour
{
    [SerializeField]
    ARTrackedImageManager m_TrackedImageManager;
    public GameObject bellPrefab; //Prefab you want to appear on marker image
    public GameObject giftboxPrefab; //Prefab you want to appear on marker image
    public GameObject wordsPrefab; //Prefab you want to appear on marker image

    void Start()
    {
        // Disable screen dimming
      //  Screen.sleepTimeout = SleepTimeout.NeverSleep;
Debug.Log("start");
    
    }

    void OnEnable() => m_TrackedImageManager.trackedImagesChanged += OnChanged;

    void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

    

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
       AudioSource source = GetComponent<AudioSource>();

        // When the camera picks up a new image marker Unity adds a game object to it called newImage, this will stick to maker.
        foreach (ARTrackedImage newImage in eventArgs.added)
        {

         

            if(newImage.referenceImage.name == "cross") {
                // Create new copy of your prefab
                GameObject newObject = GameObject.Instantiate(bellPrefab);
                // parent prefab to the newImage so that they stick together.
                newObject.transform.SetParent(newImage.transform, false);
            }else if(newImage.referenceImage.name == "sign")
            {
                GameObject newObject = GameObject.Instantiate(giftboxPrefab);
                newObject.transform.SetParent(newImage.transform, false);
            }
            else if(newImage.referenceImage.name == "map")
            {
                GameObject newObject = GameObject.Instantiate(wordsPrefab);
                newObject.transform.SetParent(newImage.transform, false);
            }
            source.Play();
        }
    }
}