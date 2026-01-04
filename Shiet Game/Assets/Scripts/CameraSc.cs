using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSc : MonoBehaviour
{


    public Transform target;  
    public float zOffset = -10f;
    public float Speed = 5f; //player ile aynı hızda

    void LateUpdate()
    {
        float targetZ = target.position.z + zOffset;

        Vector3 pos = transform.position;
        pos.z = Mathf.Lerp(pos.z, targetZ, Speed * Time.deltaTime);

        transform.position = pos;
    }
}
