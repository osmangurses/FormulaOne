using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed=0;
    public float ivme,maxSpeed;
    public RoadCreator roadCreator;
    public GameObject cursor;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "passPoint")
        {
            roadCreator.CreateNewRoad(other.transform.parent.gameObject);
        }
    }
    private void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && cursor.GetComponent<RectTransform>().localPosition.x>-70 && cursor.GetComponent<RectTransform>().localPosition.x < 70)
        {
            maxSpeed *= 1.5f;
        }
        if (Input.GetMouseButton(0))
        {
            if (speed<maxSpeed)
            {
                speed += ivme;
            }
        }
        else
        {
            if (speed>0)
            {
                speed -= ivme;
            }
            else if(speed<0)
            {
                speed = 0;
            }
        }
    }
}
