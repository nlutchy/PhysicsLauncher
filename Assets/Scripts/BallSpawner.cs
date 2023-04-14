using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
   
    public GameObject ballSpawnPos;
    public GameObject Ball;

    Material buttonMat;

    void Start()
    {   //Locates the material for this object
        buttonMat = GetComponent<Renderer>().material;
    }
    
    private void OnMouseDown()
    {   //Spawns the ball at selected location
        Instantiate(Ball, ballSpawnPos.transform);
    }


    private void OnMouseOver()
    {   //Changes the colour of the material to red
        buttonMat.color = Color.red;
    }

    private void OnMouseExit()
    {   //Changes the colour of the material to white
        buttonMat.color = Color.white;
    }


}
