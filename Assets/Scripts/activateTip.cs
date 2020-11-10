using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activateTip : MonoBehaviour
{
    GameObject sc;
    RectTransform rct;
    Text txt;
    Camera cam;
    private Vector3 position;
    private float startTime,delay;
    bool click = true;
    void Start()
    {
        rct = GetComponent<RectTransform>();
        txt = GetComponent<Text>();
        cam = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (click) {
                startTime = Time.time;
            }

            //position = cam.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 0.75f);
            //rct.position = position;
        }
        if (Input.GetMouseButton(0)) {
            if (click) {
                delay = Time.time - startTime;
                if (delay > 1.3f) {
                    txt.enabled = true;
                    position = cam.ScreenToWorldPoint(Input.mousePosition) + new Vector3(1, 1, 1f);
                    rct.position = position;
                }
            }
        }
        if (Input.GetMouseButtonUp(0)) {
            if (click) {
                txt.enabled = false;
                Debug.Log(delay);
            }
            click = false;
        }
    }
}
