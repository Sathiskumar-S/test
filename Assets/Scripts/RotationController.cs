using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public GameObject PlaneObject;
    public Vector3 RotationObject;

    // Update is called once per frame
    private void Update()
    {
        PlaneObject.transform.Rotate(RotationObject * Time.deltaTime);
    }
}
