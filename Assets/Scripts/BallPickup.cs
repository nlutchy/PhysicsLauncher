using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BallPickup : MonoBehaviour
{

    Material BallMat;
    
    private bool ObjHeld;

    GameObject BallPos;
    
    void Start()
    {   //Gets the material of this object
        BallMat = GetComponent<Renderer>().material;
    }

    
    void Update()
    {   //Moves the ball to the selected gameobject position
        BallPos = GameObject.FindWithTag("Hold");       
        if (ObjHeld == true)
      {
            gameObject.transform.position = BallPos.transform.position;
      }
    }

    private void OnMouseOver()
    {   //Changes the colour of the material to yellow
        BallMat.color = Color.yellow;
    }

    private void OnMouseExit()
    {   //Changes the colour of the material to white
        BallMat.color = Color.white;
    }

    private void OnMouseDown()
    {   //Identifies when the ball is held and disables physics
        ObjHeld = true;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent <Rigidbody>().isKinematic = true;
    }

    private void OnMouseUp()
    {   //Identifies when the ball is not held and enables physics
        ObjHeld = false;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
