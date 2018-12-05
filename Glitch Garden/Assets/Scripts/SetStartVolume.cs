using System.Collections;
using UnityEngine;

public class SetStartVolume : MonoBehaviour {

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();

        if (musicManager)
        {
            float volume = PlayerprefsManager.GetMasterVolume();
            musicManager.ChangeVolume(volume);
        }
        else 
        {
            Debug.LogWarning("No music manager found in Start scene, can't set volume");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
