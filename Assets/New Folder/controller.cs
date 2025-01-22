using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class controller : MonoBehaviour
{
    private float vertical;
    private float horizontal;
    private float sensitivity = 1.50f;
    
       void  Start()

    { 
    Cursor.lockState = CursorLockMode.Locked;
    }


        
    

    // Update is called once per frame
    void Update()
     
    {
        vertical = Input.GetAxis("Mouse Y") * sensitivity;
        horizontal = Input.GetAxis("Mouse X") * sensitivity;
        transform.Rotate(0, 0, vertical);
        transform.Rotate(0, horizontal,0 );
        
    }
}
