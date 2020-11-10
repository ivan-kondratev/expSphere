using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragIndicator : MonoBehaviour
{
    Vector3 startPos, endPos, camOffset = new Vector3(0, 0, 1);
    Camera camera;
    LineRenderer lr;
    [SerializeField] AnimationCurve ac;
    void Start()
    {
        camera = Camera.main;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (lr == null) {
                lr = gameObject.AddComponent<LineRenderer>();
            }
            lr.enabled = true;
            lr.positionCount = 2;
            startPos = camera.ScreenToWorldPoint(Input.mousePosition) + camOffset;
            lr.SetPosition(0, startPos);
            lr.useWorldSpace = true;
            lr.widthCurve = ac;
            lr.numCapVertices = 10;
        }
        if (Input.GetMouseButton(0)) {
            endPos = camera.ScreenToWorldPoint(Input.mousePosition) + camOffset;
            lr.SetPosition(1, endPos);
            //float Dist = Vector3.Distance(startPos, endPos);
        }
        if (Input.GetMouseButtonUp(0)) {
            lr.enabled = false;
            //Debug.Log(Vector3.Distance(startPos, endPos));
        }
    }
}
