using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelFailed : MonoBehaviour
{
    public GameObject Picture,Text,Button,ButtonText;
    Image img,button;
    Text txt,buttonText;
    private float delay, startDelay;
    bool col = false;
    void Start()
    {
        img = Picture.GetComponent<Image>();
        button = Button.GetComponent<Image>();
        txt = Text.GetComponent<Text>();
        buttonText = ButtonText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (col) {
            delay = Time.time - startDelay;
            if (delay > 3) {
                img.enabled = true;
                button.enabled = true;
                txt.enabled = true;
                buttonText.enabled = true;
            }
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            startDelay = Time.time;
            col = true;
        }
    }
}
