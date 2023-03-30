using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    Material ButtonMat;
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
        
    }
}
