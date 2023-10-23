using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectACollectable : MonoBehaviour
{
    [SerializeField]
    float speed;
    private void Update()
    {
        transform.Rotate(0, speed, 0.0f, Space.Self);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") Destroy(gameObject,0.05f);
    }
}
