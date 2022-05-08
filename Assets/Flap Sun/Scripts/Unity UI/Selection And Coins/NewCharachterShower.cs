using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewCharachterShower : MonoBehaviour
{
    public Animator imgPlayers;
    public int pricePl2;
    public int pricePl3;
    public Sprite[] images;
    int currentImage;
    public Image imgShower;
    public Text priceText;
    public GameObject[] HideButtons;


    public GameObject confirmPurchase;
    public GameObject noCoinsPurchase;
    // Start is called before the first frame update
    void Start()
    {
       PlayerPrefs.SetInt("Char0", 1);
       currentImage = 0;
    }
    public void clickNext()
    {
        imgPlayers.SetTrigger("Play");
    }
    public void clickBack()
    {
        imgPlayers.SetTrigger("PlayBack");
    }
    public void changeImage(int ok)
    {

        if (ok == 1)
        {
          
            if (currentImage < images.Length)
            {
                currentImage++;
                if (currentImage == 3)
                {
                    currentImage = 0;
                }
                   
            }
        }


        if (ok == 0)
        {
            currentImage--;
            if (currentImage < 0)
            {
                currentImage = 2;
            }
           
        }

        imgShower.sprite = images[currentImage];

        if (PlayerPrefs.GetInt("Char" + currentImage) == 0)
        {
            purchased(false);
        }
        else
        {
            purchased(true);
        }
    }

    void purchased(bool purchasedd)
    {
        
        HideButtons[0].SetActive(purchasedd);
        HideButtons[1].SetActive(purchasedd);
        HideButtons[2].SetActive(purchasedd);

        if (purchasedd == false)
        {
            if (currentImage == 1)
            {
                priceText.text = "BUY      " + pricePl2;
            }
            if (currentImage == 2)
            {
                priceText.text = "BUY      " + pricePl3;
            }
        }
      
    }
    public void PurchaseIt()
    {
        if (currentImage == 1)
        {
            if (PlayerPrefs.GetInt("Coins") >= pricePl2)
            {
                confirmPurchase.SetActive(true);
            }
            else
            {
                noCoinsPurchase.SetActive(true);
            }
        }
        if (currentImage == 2)
        {
            if (PlayerPrefs.GetInt("Coins") >= pricePl3)
            {
                confirmPurchase.SetActive(true);
            }
            else
            {
                noCoinsPurchase.SetActive(true);
            }
        }
    }
    public void ConfirmPurchase()
    {
        if (currentImage == 1)
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - pricePl2);
            PlayerPrefs.SetInt("Char1", 1);
            purchased(true);
        }
        if (currentImage == 2)
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - pricePl3);
            PlayerPrefs.SetInt("Char2", 1);
            purchased(true);
        }
    }
    private void Update()
    {
        PlayerPrefs.SetInt("CharToPlay", currentImage);
        if (Input.GetKeyDown(KeyCode.T))
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 100);
        }
    }
}
