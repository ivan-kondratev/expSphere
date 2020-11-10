using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeController : MonoBehaviour
{

    Camera cam;
    private Vector3 position;
    Image img;
    public RectTransform rctPos;
    Color lerpedColor = Color.white;
    bool click = true;
    void Start() {
        cam = Camera.main;
        rctPos = GetComponent<RectTransform>();
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            if (click) {
                img = GetComponent<Image>();
                position = cam.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 0.75f);
                img.enabled = true;
                rctPos.position = position;
            }
        }
        if (Input.GetMouseButton(0)) {
            rctPos.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            if (rctPos.localScale.x < 0.3f) {
                lerpedColor = Color.Lerp(Color.white, Color.green, Mathf.PingPong(Time.time, 0.3f));
            }
            if (rctPos.localScale.x > 0.3f && rctPos.localScale.x < 0.7f) {
                lerpedColor = Color.Lerp(Color.green, Color.yellow, Mathf.PingPong(Time.time, 0.4f));
            }
            if (rctPos.localScale.x > 0.7f && rctPos.localScale.x < 1.0f) {
                lerpedColor = Color.Lerp(Color.yellow, Color.red, Mathf.PingPong(Time.time, 0.3f));
            }
            if (rctPos.localScale.x > 1.0f) {
                lerpedColor = Color.red;
            }
            if (rctPos.localScale.x > 1.2f) {
                rctPos.localScale = new Vector3(1.2f, 1.2f);
            }
            img.color = lerpedColor;
        }
        if (Input.GetMouseButtonUp(0)) {
            if (click) {
                img.enabled = false;
                rctPos.localScale = new Vector3(0.1f, 0.1f, 1f);
            }
            click = false;
        }

    }
}
