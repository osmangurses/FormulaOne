using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCreator : MonoBehaviour
{
    public GameObject roadPrefab;
    

    public void CreateNewRoad(GameObject roadTemp)
    {
        roadTemp.transform.position += Vector3.forward * 366;

    }
}
