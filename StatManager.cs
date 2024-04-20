using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour
{
    public Text moneyText;
    public Text healthText;
    public Text revenueText;
    public Text deathText;
    public Text breedingText;
    public Text pricePerChickenText;
    public Text rateSoldText;
    public Text operationText;
    public Text capacityText;
    public Text populationText;
    public Text densityText;
    static public float money;
    static public float health;
    static public float revenue;
    static public float death;
    static public float breedingRate;
    static public float pricePerChicken;
    static public float rateSold;
    static public float operationCost;
    static public float capacity;
    static public float population;
    static public float density;
    // Start is called before the first frame update
    private float updateTime = 1f;

    void Start()
    {
        money = float.Parse(moneyText.text);
        health = float.Parse(healthText.text);
        revenue = float.Parse(revenueText.text);
        death = float.Parse(deathText.text);
        breedingRate = float.Parse(breedingText.text);
        pricePerChicken = float.Parse(pricePerChickenText.text);
        rateSold = float.Parse(rateSoldText.text);
        operationCost = float.Parse(operationText.text);
        capacity = float.Parse(capacityText.text);
        population = float.Parse(populationText.text);
        density = float.Parse(densityText.text);

        InvokeRepeating("changeStats", 0, updateTime);
    }

    // Updates UI
    void Update()
    {
        moneyText.text = money.ToString("F2");
        healthText.text = health.ToString();
        revenueText.text = revenue.ToString("F2");
        deathText.text = death.ToString();
        breedingText.text = breedingRate.ToString();
        pricePerChickenText.text = pricePerChicken.ToString("F2");
        rateSoldText.text = rateSold.ToString();
        operationText.text = operationCost.ToString("F2");
        capacityText.text = capacity.ToString();
        populationText.text = population.ToString();
        densityText.text = density.ToString();
    }

    private void changeStats() {
        // stats not updated here: 
        // health, breedingRate, pricePerChicken, rateSold, operationCost, capacity, population
        float rate = 60 * updateTime;

        money += revenue / rate;
        money -= operationCost / rate;
        revenue = pricePerChicken * rateSold;
        death = health / 50f;
        density = population / capacity;
    }

    // Updates when food upgrade is bought
    public void updateFoodStats() {
        moneyText.text = money.ToString("F2");
        healthText.text = health.ToString();
        breedingText.text = breedingRate.ToString();
        operationText.text = operationCost.ToString("F2");
    }
}
