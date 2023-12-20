using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CablesConnection : MonoBehaviour
{
    [SerializeField] Transform[] points;
    LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        for(int i =0; i < points.Length; i++)
        {
            lineRenderer.SetPosition(i, points[i].position);
        }
    }
}
