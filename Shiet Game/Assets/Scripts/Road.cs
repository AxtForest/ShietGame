using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
  
    [SerializeField] GameObject road;

    float roadLength = 111.6f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>() != null)
        {
            Vector3 spawnPos = transform.position + Vector3.forward * roadLength;
            Instantiate(road, spawnPos, Quaternion.identity);
        }

        
    }

    

}
