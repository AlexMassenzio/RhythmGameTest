/*
 * Conductor.cs
 * Referenced from this great article: https://www.reddit.com/r/gamedev/comments/2fxvk4/heres_a_quick_and_dirty_guide_i_just_wrote_how_to/
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour {

    public float bpm = 120;
    public float crotchet;
    public float songPosition;
	public float deltaSongPosition;
    public float offset = 0f; //positive means the song must be minussed.
	public int beat;

	private AudioSource song;

	// Use this for initialization
	void Start () {
		song = GetComponent<AudioSource>();
		beat = 0;
		crotchet = 0;
	}
	
	// Update is called once per frame
	void Update () {
		float oldSongPosition = songPosition;
		songPosition = song.time - offset;
		deltaSongPosition = songPosition - oldSongPosition;

		if(crotchet >= 60f / bpm)
		{
			beat++;
			crotchet -= 60f / bpm;
		}
		else
		{
			crotchet += deltaSongPosition;
		}

		Debug.Log("beat: " + beat);
		Debug.Log("crotchet: " + crotchet);
	}
}
