using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactions : MonoBehaviour
{
    bool annotationVisible = false;
    public GameObject annotation;

    public void selected()
    {
        Debug.Log("show selected");
        if (annotationVisible)
        {
            annotation.SetActive(false);
            annotationVisible = false;

        } else {
            annotation.SetActive(true);
            annotationVisible = true;

        }
    }
}
