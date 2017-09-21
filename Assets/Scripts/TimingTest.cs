using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimingTest : MonoBehaviour {

    private Conductor conductor;

    public Text debugText;

    public float window = 0.1f;

    private float inputLag = 0.15f;

	// Use this for initialization
	void Start () {
        conductor = GameObject.Find("Conductor").GetComponent<Conductor>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(conductor.crotchet);
            debugText.text = conductor.crotchet.ToString();
            debugText.color = Color.white;
            if (conductor.crotchet - inputLag < window / 2f || conductor.crotchet - inputLag > conductor.beatDuration - window / 2f)
            {
                debugText.color = Color.green;
                GetComponent<AudioSource>().Play();
            }
        }
	}
}
