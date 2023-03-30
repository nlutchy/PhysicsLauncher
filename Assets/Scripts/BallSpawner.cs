using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
   
    public GameObject BallSpawnPos;
    public GameObject Ball;

    Material ButtonMat;

    void Start()
    {
        ButtonMat = GetComponent<Renderer>().material;
    }
    
    private void OnMouseDown()
    {
        Instantiate(Ball, BallSpawnPos.transform);
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
