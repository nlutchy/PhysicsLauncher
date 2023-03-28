using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
   
    public GameObject BallSpawnPos;
    public GameObject Ball;
    
    bool spawnBall;
    
    Material ButtonMat;

    void Start()
    {
        ButtonMat = GetComponent<Renderer>().material;
    }


    void Update()
    {
        if(spawnBall == true)
        {
            Instantiate(Ball, BallSpawnPos.transform);
        }
       
    }
    
    private void OnMouseDown()
    {
        spawnBall = true;
    }

    private void OnMouseUp()
    {
        spawnBall = false; 
    }

    private void OnMouseOver()
    {
        ButtonMat.color = Color.red;
    }

    private void OnMouseExit()
    {
        ButtonMat.color = Color.white;
    }


}
