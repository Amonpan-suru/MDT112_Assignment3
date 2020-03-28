using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{public GameObject goalGameobject;    
    void OnMouseDrag() {

        
        Vector3 MousePos = Input.mousePosition;
        MousePos.z = transform.position.z - Camera.main.transform.position.z;
        MousePos = Camera.main.ScreenToWorldPoint(MousePos);
        
        transform.position = new Vector3 (MousePos.x,MousePos.y,transform.position.z);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.Equals(goalGameobject)){
            Debug.Log("Win");
        }
    }
}
