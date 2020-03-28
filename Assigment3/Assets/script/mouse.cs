using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    
    private void OnMouseDrag()
    {
        Vector3 mousePosWorld = Input.mousePosition;
        mousePosWorld.z = transform.position.z - Camera.main.transform.position.z;
        mousePosWorld = Camera.main.ScreenToViewportPoint(mousePosWorld);

        transform.position = new Vector3(mousePosWorld.x, mousePosWorld.y, transform.position.z);
        //Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(gameObject.name);
    }
/*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals())
        {
            Debug.Log("win");
        }
    }
    */

}
