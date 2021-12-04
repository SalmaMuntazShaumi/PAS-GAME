using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject balltarget;
    public float xOffset, yOffset, zOffset;


    // Update is called once per frame
    void Update()
    {
        transform.position = balltarget.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(balltarget.transform.position);


    }
    void Start()
    {
        
    }
}
