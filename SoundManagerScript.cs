using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

	public static AudioClip ExplosionPlayerSound, LaserPlayerSound, playerhurtSound;
	static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        ExplosionPlayerSound = Resources.Load<AudioClip> ("ExplosionPlayer");
		LaserPlayerSound = Resources.Load<AudioClip> ("LaserPlayer");
		playerhurtSound = Resources.Load<AudioClip> ("playerhurt");

		audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

	public static void PlaySound (string clip)
	{
	
		switch (clip) {
		case "ExplosionPlayer":
			audioSrc.PlayOneShot (ExplosionPlayerSound);
			break;
		case "LaserPlayer":
			audioSrc.PlayOneShot (LaserPlayerSound);
			break;
		case "playerhurt":
			audioSrc.PlayOneShot (playerhurtSound);
			break;
		}
	}
}
