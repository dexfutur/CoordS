using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrices : MonoBehaviour
{
    [SerializeField] Vector4 location;
    void Start()
    {


    }


    void Update()
    {
        //Matrix4x4 matrix = new Matrix4x4(new Vector4(1, 0, 0, 0), new Vector4(1, 0, 0, 0));
        Vector4 LocalPosition = transform.localPosition; LocalPosition.w = 1;

        //transform.localPosition = matrix * LocalPosition;

    }
}
