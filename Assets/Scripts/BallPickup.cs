using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BallPickup : MonoBehaviour
{

    Material ballMat;
    
    private bool objHeld = false;

    GameObject ballPos;
    
    void Start()
    {   //Gets the material of this object
        ballMat = GetComponent<Renderer>().material;
    }

    
    void Update()
    {   //Moves the ball to the selected gameobject position
        ballPos = GameObject.FindWithTag("Hold");       
        if (objHeld == true)
      {
            gameObject.transform.position = ballPos.transform.position;
      }
    }

    private void OnMouseOver()
    {   //Changes the colour of the material to yellow
        ballMat.color = Color.yellow;
    }

    private void OnMouseExit()
    {   //Changes the colour of the material to white
        ballMat.color = Color.white;
    }

    private void OnMouseDown()
    {   //Identifies when the ball is held and disables physics
        objHeld = true;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent <Rigidbody>().isKinematic = true;
    }

    private void OnMouseUp()
    {   //Identifies when the ball is not held and enables physics
        objHeld = false;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
