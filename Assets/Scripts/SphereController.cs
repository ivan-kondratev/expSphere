using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    Rigidbody rb;
    public GameObject obj;
    private float delay, delayStartTime;
    public float getDelay() { return delay; }
    public int triggerCount;
    bool click;


    void Start() {
        rb = GetComponent<Rigidbody>();
        triggerCount = 0;
        click = true;
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            delayStartTime = Time.time;
            obj.SetActive(false);
        }
        if (Input.GetMouseButtonUp(0)) {
            if (click) {
            rb.AddForce(new Vector3(200, 0));
            delay = (float)System.Math.Round(Time.time - delayStartTime, 1);
            if (delay > 2.5) {
                delay = 2.5f;
            }
            Debug.Log(delay);
            } click = false;
        }
    }
    private void FixedUpdate() {
        if (delay > 0) {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            delay -= 0.01f;
        }
    }

    private void OnTriggerEnter(Collider collision) {
        string tag = collision.gameObject.tag;
        Debug.Log(tag);
        ++triggerCount;
        Debug.Log("sc-TrigCount = " + triggerCount);
    }
}

    
