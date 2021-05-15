using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    public float rotationSpeed = 1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tiltSpeedScale = rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward * tiltSpeedScale);
    }
}
