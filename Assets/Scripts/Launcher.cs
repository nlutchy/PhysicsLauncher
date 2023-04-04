using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    Material ButtonMat;
    bool ButtonDown;
    public int Force;
 
    void Start()
    {
        ButtonMat = GetComponent<Renderer>().material;
    }

    private void OnMouseOver()
    {
        ButtonMat.color = Color.red;
    }

    private void OnMouseExit()
    {
        ButtonMat.color = Color.white;
    }

    private void OnMouseDown()
    {
        ButtonDown = true;
    }
    private void OnMouseUp()
    {
        ButtonDown = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ball" && ButtonDown == true)
        {
            other.attachedRigidbody.AddForce(Vector3.back * Force);
            
        }      

    }

}
