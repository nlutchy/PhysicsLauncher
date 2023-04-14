using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    Material buttonMat;
    bool buttonDown = false;
    public int Force = 100;
 
    void Start()
    {   //Gets the material of this object
        buttonMat = GetComponent<Renderer>().material;
    }

    private void OnMouseOver()
    {   //Changes the colour of the material to red
        buttonMat.color = Color.red;
    }

    private void OnMouseExit()
    {   //Changes the colour of the material to white
        buttonMat.color = Color.white;
    }

    private void OnMouseDown()
    {   //Detects if the button has been pressed
        buttonDown = true;
    }
    private void OnMouseUp()
    {   //Detects if the button has be released
        buttonDown = false;
    }
    private void OnTriggerStay(Collider other)
    {   //Adds force to the ball if it is detected and button is pressed
        if (other.gameObject.tag == "Ball" && buttonDown == true)
        {
            other.attachedRigidbody.AddForce(Vector3.back * Force);
            
        }      

    }

}
