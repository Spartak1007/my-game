using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    static int num = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        num = num + 1;
        print(num);
        Destroy(gameObject);
        if(num==6){
            print("Выполнено");
        }
        if(Input.GetKeyDown("f"))
        {
            print("passed");
            
        }
    }
}
