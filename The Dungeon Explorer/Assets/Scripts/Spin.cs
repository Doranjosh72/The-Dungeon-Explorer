using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    // this will rotate the object in the direction you want it too.
    void Update()
    {
        transform.Rotate(0f, 0.5f, 0f, Space.Self);
    }
}
