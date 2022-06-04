using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 12f;
    CharacterController character;
    bool isGrounded = false;
    Transform playerBody;
    float graValue = -15f;
    public GameObject door;
    Transform doorTr;
    float jumpHeight = 5f;
    float distanceToDoor;

    float distance = 10f;
    
    // Start is called before the first frame update
    public HandController HandController;
    void Start()
    {
        character = GetComponent<CharacterController>();
        playerBody = GetComponent<Transform>();
        door = GameObject.Find("door");
        doorTr = door.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        character.Move(transform.forward * vertical * speed * Time.deltaTime);
        character.Move(transform.right * horizontal * speed * Time.deltaTime);
        character.Move(playerBody.up * graValue * Time.deltaTime);

        if(Input.GetKeyDown("space")&& isGrounded == true){
            character.Move(playerBody.up * jumpHeight);
        } else {
            isGrounded = true;
        }

        
        distanceToDoor = Vector3.Distance(character.transform.position, doorTr.position);

        if (distanceToDoor <= distance){
            HandController.destroyPack();
        }
    }
    void OnControllerColliderHit(ControllerColliderHit col){
        if(col.gameObject.tag == "ground"){
            isGrounded = true;
        }
        if(col.gameObject.tag == "destroy"){
                print("П");
                Destroy(col.gameObject);
        }
        if(col.gameObject.tag == "color"){
            
        }
    }
}
