using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTest : MonoBehaviour {

	private Conductor conductor;
	private Color mood;
	private int observedBeat;

	// Use this for initialization
	void Start()
	{
		conductor = GameObject.Find("Conductor").GetComponent<Conductor>();
		mood = Color.white;
	}

	// Update is called once per frame
	void Update()
	{
		float progress = conductor.crotchet / (60f / conductor.bpm);

		if (conductor.beat % 8 == 0 && conductor.beat != observedBeat)
		{
			mood = new Color(Random.Range(0.2f, 1f), Random.Range(0.2f, 1f), Random.Range(0.2f, 1f));
		}

		observedBeat = conductor.beat;

		GetComponent<Light>().color = mood * Mathf.Lerp(1f, 0f, progress);
	}
}
