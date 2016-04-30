using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class PlayMusic : MonoBehaviour {
	
	public AudioClip[] musicClips;					//Array of music clips to play
	public AudioMixerSnapshot volumeDown;			//Reference to Audio mixer snapshot in which the master volume of main mixer is turned down
	public AudioMixerSnapshot volumeUp;				//Reference to Audio mixer snapshot in which the master volume of main mixer is turned up


	private AudioSource musicSource;				//Reference to the AudioSource which plays music
	
	void Awake () 
	{
		//Get a component reference to the AudioSource attached to the UI game object
		musicSource = GetComponent<AudioSource> ();
	}

	//Once the level has loaded, call PlayLevelMusic
	public void PlaySelectedMusic(int musicChoice)
	{
		musicSource.clip = musicClips [musicChoice];
		musicSource.Play ();
	}

	public void FadeUp(float fadeTime)
	{
		//call the TransitionTo function of the audioMixerSnapshot volumeUp;
		volumeUp.TransitionTo (fadeTime);
	}

	public void FadeDown(float fadeTime)
	{
		//call the TransitionTo function of the audioMixerSnapshot volumeDown;
		volumeDown.TransitionTo (fadeTime);
	}
}
