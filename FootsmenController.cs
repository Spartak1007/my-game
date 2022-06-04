using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootsmenController : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    float v;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");
        if(v > 0){ 
            anim.SetBool("step", true);
            if(Input.GetKeyDown("w")){
                anim.SetBool("step", true);
            } 
            if(Input.GetKeyUp("w")){
                anim.SetBool("step", false);
            } 
            if(Input.GetKeyDown("space")){
                anim.SetBool("jump", true);
            } 
            if(Input.GetKeyUp("space")){
                anim.SetBool("jump", false);
            } 
        }else {
            anim.SetBool("step", false);
        }
    }
}
