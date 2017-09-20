/*
 * Conductor.cs
 * Referenced from this great article: https://www.reddit.com/r/gamedev/comments/2fxvk4/heres_a_quick_and_dirty_guide_i_just_wrote_how_to/
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour {

    int crotchetsPerBar = 8;
    public float bpm = 120;
    public float crotchet;
    public float songPosition;
    public float offset = 0.2f; //positive means the song must be minussed.

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
