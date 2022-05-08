using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCounter : MonoBehaviour
{
    public int currentCoins;
    public Text coinsDisplayer;
    public static CoinsCounter instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
      
    }

    // Update is called once per frame
    void Update()
    {
        currentCoins = PlayerPrefs.GetInt("Coins");
        coinsDisplayer.text = currentCoins.ToString();
    }
    public void increaseCoins()
    {
        currentCoins++;
        
        PlayerPrefs.SetInt("Coins", currentCoins);
    }

   
}
