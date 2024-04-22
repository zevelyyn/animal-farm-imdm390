using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TechTree : MonoBehaviour
{
    // Includes Business Tree Decisions
    public static bool CornBought = false;
    public static bool WormBought = false;
    public static bool HormoneBought = false;
    public static bool SteroidBought = false;
    public static bool VentilationBought = false;
    public static bool SkylightBought = false;
    public static bool CageBought = false;
    public static bool EfficientBought = false;
    public static bool StunnerBought = false;
    public static bool HalalBought = false;
    public static bool Beheader3000Bought = false;
    public static bool Beheader5000Bought = false;
    public static bool LocalMarketBought = false;
    public static bool TraderJoesBought = false;
    public static bool FiveBelowBought = false;
    public static bool WalmartBought = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BuyCorn() {
        StatManager.money -= 50000f;
        StatManager.health += 5f;
        StatManager.breedingRate += 2f;
        StatManager.operationCost += 800;
        CornBought = true;
    }

    public void BuyWorm() {
        StatManager.money -= 90000f;
        StatManager.health += 15f;
        StatManager.breedingRate += 2f;
        StatManager.operationCost += 2000f;
        WormBought = true;
    }

    public void BuyGrowthHormone() {
        StatManager.money -= 30000f;
        StatManager.health -= 5f;
        StatManager.breedingRate += 10f;
        StatManager.operationCost += 600f;
        HormoneBought = true;
    }

    public void BuySteroid() {
        StatManager.money -= 100000f;
        StatManager.health -= 50f;
        StatManager.breedingRate += 80f;
        StatManager.operationCost += 1000f;
        SteroidBought = true;
        // sound.Play();
    }

    public void BuyVentilation() {
        StatManager.money -= 50000f;
        StatManager.health += 5f;
        StatManager.operationCost += 1000f;
        VentilationBought = true;
    }

    public void BuySkylight() {
        StatManager.money -= 120000;
        StatManager.health += 10f;
        StatManager.operationCost += 500f;
        SkylightBought = true;
    }

    public void BuyCage() {
        StatManager.money -= 30000f;
        StatManager.health -= 20f;
        float cap = StatManager.capacity;
        StatManager.capacity += 4 * cap / 10;
        StatManager.operationCost += 800f;
        CageBought = true;
    }

    public void BuyEfficientCage() {
        StatManager.money -= 100000f;
        float cap = StatManager.capacity;
        StatManager.capacity += 8 * cap / 10;
        StatManager.operationCost += 1800f;
        EfficientBought = true;
    }

    public void BuyStunner() {
        StatManager.money -= 100000f;
        StatManager.operationCost += 1200f;
        StunnerBought = true;
    }
    
    public void BuyHalal() {
        StatManager.money -= 300000f;
        StatManager.operationCost += 5000f;
        HalalBought = true;
    }

    public void BuyBeheader3000() {
        StatManager.money -= 80000f;
        StatManager.operationCost += 1500f;
        Beheader3000Bought = true;
    }

    public void BuyBeheader5000() {
        StatManager.money -= 120000f;
        StatManager.operationCost += 2000f;
        Beheader5000Bought = true;
    }

    public void BuyLocal() {
        // need to have ethical food tier 1 unlocked
        // need to have ethical warehouse tier 1 unlocked
        // chicken healthiness is above 50%
        StatManager.rateSold += 5f;
        LocalMarketBought = true;
    }

    public void BuyTraderJoes() {
        // need to have ethical food tier 2 unlocked
        // need to have ethical warehouse tier 2 unlocked
        // need to have ethical machine tier 1 unlocked
        // chicken healthiness is above 75%
        StatManager.rateSold += 15f;
        float ppc = StatManager.pricePerChicken;
        StatManager.pricePerChicken += ppc / 10f;
        TraderJoesBought = true;
    }

    public void BuyWholeFoods() {
        // need to have ethical machine tier 2 unlocked
        // chicken healthiness is above 90%
        StatManager.rateSold += 100f;
        float ppc = StatManager.pricePerChicken;
        StatManager.pricePerChicken += ppc / 5f;
    }

    public void BuyFiveBelow() {
        // need to have unethical food tier 1 unlocked
        // need to have unethical warehouse tier 1 unlocked
        StatManager.rateSold += 25f;
        FiveBelowBought = true;
    }

    public void BuyWalmart() {
        // need to have unethical food tier 2 unlocked
        // need to have unethical warehouse tier 2 unlocked
        // need to have unethical machine tier 1 unlocked
        StatManager.rateSold += 25f;
        WalmartBought = true;
    }

    public void BuyMcDonalds() {
        // need to have unethical machine tier 2 unlocked
        StatManager.rateSold += 200f;
    }
}
