using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    Material ButtonMat;
    bool ButtonDown;
    public int Force;
 
    void Start()
    {   //Gets the material of this object
        ButtonMat = GetComponent<Renderer>().material;
    }

    private void OnMouseOver()
    {   //Changes the colour of the material to red
        ButtonMat.color = Color.red;
    }

    private void OnMouseExit()
    {   //Changes the colour of the material to white
        ButtonMat.color = Color.white;
    }

    private void OnMouseDown()
    {   //Detects if the button has been pressed
        ButtonDown = true;
    }
    private void OnMouseUp()
    {   //Detects if the button has be released
        ButtonDown = false;
    }
    private void OnTriggerStay(Collider other)
    {   //Adds force to the ball if it is detected and button is pressed
        if (other.gameObject.tag == "Ball" && ButtonDown == true)
        {
            other.attachedRigidbody.AddForce(Vector3.back * Force);
            
        }      

    }

}
