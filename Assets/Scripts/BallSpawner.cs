using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
   
    public GameObject BallSpawnPos;
    public GameObject Ball;

    Material ButtonMat;

    void Start()
    {   //Locates the material for this object
        ButtonMat = GetComponent<Renderer>().material;
    }
    
    private void OnMouseDown()
    {   //Spawns the ball at selected location
        Instantiate(Ball, BallSpawnPos.transform);
    }


    private void OnMouseOver()
    {   //Changes the colour of the material to red
        ButtonMat.color = Color.red;
    }

    private void OnMouseExit()
    {   //Changes the colour of the material to white
        ButtonMat.color = Color.white;
    }


}
