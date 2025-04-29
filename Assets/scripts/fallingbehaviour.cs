using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingbehaviour : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void SelectGift()
{
gameObject.SetActive(true);


    animator.SetTrigger("falling");
}

    // private void onTriggerEnter(Collider other){
    //     if(other.tag == "Player")
    //     {
    //         animator.SetTrigger("falling");
    //     }
    // }
}
