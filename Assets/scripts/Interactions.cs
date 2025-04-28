using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    bool annotationVisible = false; //current visibility of ship
    public GameObject Giftbox; // annotation object




    public void selected()
    {

        Instantiate(Giftbox, new Vector3(0,7,0), Quaternion.identity);
   

/*
        Debug.Log("falling giftbox");
        //toggle visibility of the annotation
        if (annotationVisible)
        {
          //  annotation.SetActive(false);
          // annotationVisible = false;
        }else {
           // annotation.SetActive(true);
           // annotationVisible = true;
        }
*/
    }
}
