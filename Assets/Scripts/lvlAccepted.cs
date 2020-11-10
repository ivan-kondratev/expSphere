using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvlAccepted : MonoBehaviour
{
	public GameObject obj, BUTONN, BUTONNTEXT, I, II, III, BEKGRAYND;
	public Image BUTTONN, _I_, _I_I_, _I_I_I_, BEKGRAYNDEMAGW;
	public Text BUTTONTEXT;
	private int triggerCount;    bool col = false;    private float delay, startDelay;


    // Start is called before the first frame update
    void Start() {   BUTTONN = BUTONN.GetComponent<Image>(); BUTTONTEXT = BUTONNTEXT.GetComponent<Text>(); _I_ = I.GetComponent<Image>();_I_I_ = II.GetComponent<Image>();_I_I_I_ = III.GetComponent<Image>();BEKGRAYNDEMAGW = BEKGRAYND.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
                if (col) {triggerCount = obj.GetComponent<SphereController>().triggerCount;
            delay = Time.time - startDelay;
            if (delay > 3) {
            	Debug.Log("triggerCount = " + triggerCount);
            	if (triggerCount == 2) {
            		_I_.enabled = true;
            	} else if (triggerCount == 3) {
            		_I_I_.enabled = true;
            	} else if (triggerCount == 4) {
            		_I_I_I_.enabled = true;
            	}
            	BUTTONN.enabled = true;
            	BUTTONTEXT.enabled = true;
            	BEKGRAYNDEMAGW.enabled = true;
            }
        }
    }

    private void OnCollisionEnter(Collision collision) { if (collision.gameObject.tag == "Player") { startDelay = Time.time; col = true;
        }
    }
}
