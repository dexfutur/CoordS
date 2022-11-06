using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quaternions : MonoBehaviour
{
  
    void Start()
    {
        
    }

   
    void Update()
    {
        Quaternion Q = Quaternion.Euler(0, 5, 0);
        transform.rotation = transform.rotation * Q;
    }
}
