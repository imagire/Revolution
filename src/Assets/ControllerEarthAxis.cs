using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerEarthAxis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, -transform.rotation.eulerAngles.y, 0.0f);
    }
}
