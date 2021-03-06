﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {


	public static AudioManager instance; 
	public AudioSFX audioSFX;
	public AudioPlayer audioPlayer;

	void Awake() {
		if (instance == null) {
			instance = this; 
		}
	}

	public void PlayCoinPickupSound(GameObject obj) {
		AudioSource.PlayClipAtPoint(audioSFX.coinPickup, obj.transform.position);
	}

	public void PlayJumpSound(GameObject obj) {
		AudioSource.PlayClipAtPoint(audioPlayer.jump, obj.transform.position);
	}
}
