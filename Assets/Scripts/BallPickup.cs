using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BallPickup : MonoBehaviour
{

    Material BallMat;
    
    private bool ObjHeld;

    Vector3 CameraDir;
    
    void Start()
    {
        BallMat = GetComponent<Renderer>().material;
    }

    
    void Update()
    {
              
        if (ObjHeld == true)
      {
            gameObject.transform.position = Camera.main.transform.position;
      }
    }

    private void OnMouseOver()
    {
        BallMat.color = Color.yellow;
    }

    private void OnMouseExit()
    {
        BallMat.color = Color.white;
    }

    private void OnMouseDown()
    {
        ObjHeld = true;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent <Rigidbody>().isKinematic = true;
    }

    private void OnMouseUp()
    {
        ObjHeld = false;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
