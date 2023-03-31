using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFiller : MonoBehaviour
{
    public Levels[] levels;
    // Start is called before the first frame update
    void Start()
    {
        levels[0].lvlText.text = PlayerPrefs.GetString("Score1");
        levels[1].lvlText.text = PlayerPrefs.GetString("Score2");
        levels[2].lvlText.text = PlayerPrefs.GetString("Score3");
        levels[3].lvlText.text = PlayerPrefs.GetString("Score4");
        levels[4].lvlText.text = PlayerPrefs.GetString("Score5");
    }

    // Update is called once per frame
    void Update()
    {
        levels[0].lvlText.text = PlayerPrefs.GetString("Score1");
        levels[1].lvlText.text = PlayerPrefs.GetString("Score2");
        levels[2].lvlText.text = PlayerPrefs.GetString("Score3");
        levels[3].lvlText.text = PlayerPrefs.GetString("Score4");
        levels[4].lvlText.text = PlayerPrefs.GetString("Score5");
    }
}
