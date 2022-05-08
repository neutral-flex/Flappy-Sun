using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpPurchased : MonoBehaviour
{
    public GameObject[] chars;
    public static SetUpPurchased instance;
    public GameObject me;
    private void Awake()
    {
        me = chars[PlayerPrefs.GetInt("CharToPlay")];
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
        me = chars[PlayerPrefs.GetInt("CharToPlay")];
        chars[PlayerPrefs.GetInt("CharToPlay")].SetActive(true);

        HoopGenerator.instance.player = me.GetComponent<playerScript>();

    }
}
