using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFeed;
    private int currentFeedAmount = 0;
    private GameManager gameManager;

    void Start()
    {
        hungerSlider.maxValue = amountToBeFeed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void FeedAnimal(int amount)
    {
        currentFeedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFeedAmount;

        if (currentFeedAmount >= amountToBeFeed)
        {
            gameManager.AddScore(amountToBeFeed);
            Destroy(gameObject, 0.1f);
        }
    }
}