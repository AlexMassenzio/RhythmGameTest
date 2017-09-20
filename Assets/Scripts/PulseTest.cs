using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseTest : MonoBehaviour {

	private Conductor conductor;
	private float	minScale = 1,
					maxScale = 3;


	// Use this for initialization
	void Start () {
		conductor = GameObject.Find("Conductor").GetComponent<Conductor>();
	}
	
	// Update is called once per frame
	void Update () {
		float progress = conductor.crotchet / (60f / conductor.bpm);
		transform.localScale = Vector3.one * Mathf.Lerp(maxScale, minScale, progress);
	}
}
