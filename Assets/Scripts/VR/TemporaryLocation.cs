using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporaryLocation : MonoBehaviour
{
    void Update()
    {
        transform.localPosition = Vector3.zero;
    }

    //public Transform targetObject;
    //void Update()
    //{
    //    transform.position = targetObject.position;
    //}
}
