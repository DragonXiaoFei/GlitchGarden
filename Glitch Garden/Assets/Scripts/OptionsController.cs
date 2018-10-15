
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class OptionsController : MonoBehaviour {


    public Slider volumeSlider;
    public Slider difficultySlider;
    public LevelManager levelManager;

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerprefsManager.GetMasterVolume();
        difficultySlider.value = PlayerprefsManager.GetDifficulty();
        //levelManager = GameObject.FindObjectOfType<LevelManager>();

        Debug.Log(musicManager);

        volumeSlider.value = PlayerprefsManager.GetMasterVolume();
	}

    public void saveAndExit ()
    {
        PlayerprefsManager.SetMasterVolume(volumeSlider.value);
        PlayerprefsManager.SetDifficulty(difficultySlider.value);
        levelManager.LoadLevel("01a Start");
    }
	
	// Update is called once per frame
	void Update () {
        musicManager.ChangeVolume(volumeSlider.value);
	}
    public void SetDefaults()
    {
        volumeSlider.value = 0.8f;
        difficultySlider.value = 2;
    }
}
