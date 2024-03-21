using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarMovement : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
