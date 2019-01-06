using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldItemRotation : MonoBehaviour
{
    public float rotateSpeed = 10f;
    public float bobSpeed = 0.1f;
    public float height = 0.0005f;
     
     private void Update () {
        var newY = Mathf.Cos(bobSpeed * Time.time);
        //Rotate at constant speed
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
        //Bob up and down in a Cosine wave
        transform.position += new Vector3(0,newY,0) * height;
     }
}
