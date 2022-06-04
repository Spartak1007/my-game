using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public Camera cam;
    GameObject PressE;
    GameObject end;
    GameObject hand;
    GameObject pack;
    GameObject pack1;
    GameObject pack2;
    GameObject pack3;
    GameObject pack4;
    GameObject pack5;
    
    GameObject Package;
    Transform handTr;
    Transform pacTr;
    Transform pacTr1;
    Transform pacTr2;
    Transform pacTr3;
    Transform pacTr4;
    Transform pacTr5;

    // Start is called before the first frame update
    void Start()
    {
        PressE = GameObject.Find("PressE");
        PressE.SetActive(false);
        end = GameObject.Find("end");
        end.SetActive(false);

        hand = GameObject.Find("hand");
        pack = GameObject.Find("pack");
        pack1 = GameObject.Find("pack1");
        pack2 = GameObject.Find("pack2");
        pack3 = GameObject.Find("pack3");
        pack4 = GameObject.Find("pack4");
        pack5 = GameObject.Find("pack5");
        

        handTr = hand.GetComponent<Transform>();
        pacTr = pack.GetComponent<Transform>();
        pacTr2 = pack2.GetComponent<Transform>();
        pacTr3 = pack3.GetComponent<Transform>();
        pacTr1 = pack1.GetComponent<Transform>();
        pacTr4 = pack4.GetComponent<Transform>();
        pacTr5 = pack5.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        PressE.SetActive(false);
        Debug.DrawRay(cam.transform.position, cam.transform.forward * 4f, Color.red);
        RaycastHit touch;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out touch, 4))
        {
            if(touch.transform.gameObject.tag == "pack")
            {
                PressE.SetActive(true);
                if(Input.GetKeyDown("e"))
                {
                    if(pack.GetComponent<Rigidbody>()){
                        Destroy(pack.GetComponent<Rigidbody>());
                    }
                    pacTr.position = handTr.position;
                    pacTr.rotation = handTr.rotation;
                    pacTr.SetParent(handTr);
                }
            } else
            if(touch.transform.gameObject.tag == "pack1")
            {
                PressE.SetActive(true);
                if(Input.GetKeyDown("e"))
                {
                    if(pack1.GetComponent<Rigidbody>()){
                        Destroy(pack1.GetComponent<Rigidbody>());
                    }
                    pacTr1.position = handTr.position;
                    pacTr1.rotation = handTr.rotation;
                    pacTr1.SetParent(handTr);
                }
            } else
            if(touch.transform.gameObject.tag == "pack2")
            {
                PressE.SetActive(true);
                if(Input.GetKeyDown("e"))
                {
                    if(pack2.GetComponent<Rigidbody>()){
                        Destroy(pack2.GetComponent<Rigidbody>());
                    }
                    pacTr2.position = handTr.position;
                    pacTr2.rotation = handTr.rotation;
                    pacTr2.SetParent(handTr);
                }
            } else
            if(touch.transform.gameObject.tag == "pack3")
            {
                PressE.SetActive(true);
                if(Input.GetKeyDown("e"))
                {
                    if(pack3.GetComponent<Rigidbody>()){
                        Destroy(pack3.GetComponent<Rigidbody>());
                    }
                    pacTr3.position = handTr.position;
                    pacTr3.rotation = handTr.rotation;
                    pacTr3.SetParent(handTr);
                }
            } else
            if(touch.transform.gameObject.tag == "pack4")
            {
                PressE.SetActive(true);
                if(Input.GetKeyDown("e"))
                {
                    if(pack4.GetComponent<Rigidbody>()){
                        Destroy(pack4.GetComponent<Rigidbody>());
                    }
                    pacTr4.position = handTr.position;
                    pacTr4.rotation = handTr.rotation;
                    pacTr4.SetParent(handTr);
                }
            } else
            if(touch.transform.gameObject.tag == "pack5")
            {
                PressE.SetActive(true);
                if(Input.GetKeyDown("e"))
                {
                    if(pack5.GetComponent<Rigidbody>()){
                        Destroy(pack5.GetComponent<Rigidbody>());
                    }
                    pacTr5.position = handTr.position;
                    pacTr5.rotation = handTr.rotation;
                    pacTr5.SetParent(handTr);
                }
            }
            
        }        
        if(Input.GetKeyDown("g"))
        {
            if(pacTr.position == handTr.position){
                print("passed"); 
                pacTr.parent = null;
                pack.AddComponent<Rigidbody>();
                pack.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 100f);
            } else
            if(pacTr1.position == handTr.position){
                print("passed"); 
                pacTr1.parent = null;
                pack1.AddComponent<Rigidbody>();
                pack1.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 100f);
            } else
            if(pacTr2.position == handTr.position){
                print("passed"); 
                pacTr2.parent = null;
                pack2.AddComponent<Rigidbody>();
                pack2.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 100f);
            } else
            if(pacTr3.position == handTr.position){
                print("passed"); 
                pacTr3.parent = null;
                pack3.AddComponent<Rigidbody>();
                pack3.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 100f);
            } else
            if(pacTr4.position == handTr.position){
                print("passed"); 
                pacTr4.parent = null;
                pack4.AddComponent<Rigidbody>();
                pack4.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 100f);
            } else
            if(pacTr5.position == handTr.position){
                print("passed"); 
                pacTr5.parent = null;
                pack5.AddComponent<Rigidbody>();
                pack5.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 100f);
            }
        }
    }
    public void destroyPack()
    {
        if(Input.GetKeyDown("f"))
        {
            if(pacTr.position == handTr.position)
            {
                Destroy(pack); 
                end.SetActive(true);
            } else
            if(pacTr1.position == handTr.position){
                Destroy(pack1);
                end.SetActive(true);
            } else
            if(pacTr2.position == handTr.position){
                Destroy(pack2);
                end.SetActive(true);
            } else
            if(pacTr3.position == handTr.position){
                Destroy(pack3);
                end.SetActive(true);
            } else
            if(pacTr4.position == handTr.position){
                Destroy(pack4);
                end.SetActive(true);
            } else
            if(pacTr5.position == handTr.position){
                Destroy(pack5);
                end.SetActive(true);
            }   
        }   
    }      
}
