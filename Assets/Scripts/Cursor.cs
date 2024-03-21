using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public float yon = 1;
    public float speed;
    RectTransform rtransform;
    private void Start()
    {
        rtransform = GetComponent<RectTransform>();
    }
    void Update()
    {
        rtransform.localPosition += yon * Vector3.right * speed * Time.deltaTime;
        if (rtransform.localPosition.x<-600 || rtransform.localPosition.x>600)
        {
            yon *= -1;
        }
    }
}
