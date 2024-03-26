using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class variableTesting : MonoBehaviour
{
    [SerializeField] private float money = 100;
    [SerializeField] private float healthiness = 25;
    [SerializeField] private float breedingRate = 100;
    [SerializeField] private float capacity = 100;
    public Text moneyText;
    public Text healthyText;
    public Text breedText;
    public Text capacityText;

    public Button cornButton;
    public Toggle cornToggle;
    public float costToBuyCorn;

    public Button wormButton;
    public Toggle wormToggle;
    public float costToBuyWorm;

    public Button growthHormoneButton;
    public Toggle growthHormoneToggle;
    public float costToBuyHormone;

    public Button steroidButton;
    public Toggle steroidToggle;
    public float costToBuySteroid;

    public Button ventButton;
    public Toggle ventToggle;
    public float costToBuyVent;

    public Button skyButton;
    public Toggle skyToggle;
    public float costToBuySky;

    public Button cageButton;
    public Toggle cageToggle;
    public float costToBuyCage;

    public Button bigCageButton;
    public Toggle bigCageToggle;
    public float costToBuyBigCage;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("increaseMoney", 1, 1); 
    }

    void Update() {
        if (money >= costToBuyCorn && !cornToggle.interactable) {
            cornButton.interactable = true; // Allow player to buy
        } else {
            cornButton.interactable = false; // Don't allow player to buy
        }

        if (money >= costToBuyWorm && !wormToggle.interactable && cornToggle.interactable) {
            wormButton.interactable = true;
        } else {
            wormButton.interactable = false;
        }

        if (money >= costToBuyHormone && !growthHormoneToggle.interactable) {
            growthHormoneButton.interactable = true;
        } else {
            growthHormoneButton.interactable = false;
        }

        if (money >= costToBuySteroid && !steroidToggle.interactable && growthHormoneToggle.interactable) {
            steroidButton.interactable = true;
        } else {
            steroidButton.interactable = false;
        }

        if (money >= costToBuyVent && !ventToggle.interactable) {
            ventButton.interactable = true; // Allow player to buy
        } else {
            ventButton.interactable = false; // Don't allow player to buy
        }

        if (money >= costToBuySky && !skyToggle.interactable && ventToggle.interactable) {
            skyButton.interactable = true;
        } else {
            skyButton.interactable = false;
        }

        if (money >= costToBuyCage && !cageToggle.interactable) {
            cageButton.interactable = true;
        } else {
            cageButton.interactable = false;
        }

        if (money >= costToBuyBigCage && !bigCageToggle.interactable && cageToggle.interactable) {
            bigCageButton.interactable = true;
        } else {
            bigCageButton.interactable = false;
        }

        moneyText.text = "Money:\n$" + money.ToString("F2");
        healthyText.text = "Healthiness:\n%" + healthiness.ToString();
        breedText.text = "Breeding Rate:\n%" + breedingRate.ToString();
        capacityText.text = "Capacity:\n" + capacity.ToString() + " chickens";
    }

    private void increaseMoney() {
        money += ((breedingRate / 10) + healthiness / 10) * (capacity / 100);
    }

    public void BuyOrganicCorn()
    {
        money -= costToBuyCorn;
        cornToggle.interactable = true;
        // if (money < costToBuyOrgCorn && !organicCornToggle.isOn) {
        //     Debug.Log("Not enough money to buy!");
        // }
    }

    public void CornActivate() {
        if (cornToggle.isOn) {
            healthiness += 5;
            breedingRate += 2;
        } else {
            healthiness -= 5;
            breedingRate -= 2;
        }
    }

    public void BuyWorm() {
        money -= costToBuyWorm;
        wormToggle.interactable = true;
    }

    public void WormActivate() {
        if (wormToggle.isOn){
            healthiness += 15;
            breedingRate += 5;
        } else {
            healthiness -= 15;
            breedingRate -= 5;
        }
    }

    public void BuyHormone() {
        money -= costToBuyHormone;
        growthHormoneToggle.interactable = true;
    }

    public void HormoneActivate() {
        if (growthHormoneToggle.isOn){
            healthiness -= 5;
            breedingRate += 10;
        } else {
            healthiness += 5;
            breedingRate -= 10;
        }
    }

    public void BuySteroid() {
        money -= costToBuySteroid;
        steroidToggle.interactable = true;
    }

    public void SteroidActivate() {
        if (steroidToggle.isOn){
            healthiness -= 50;
            breedingRate += 80;
        } else {
            healthiness += 50;
            breedingRate -= 80;
        }
    }

    public void BuyVent() {
        money -= costToBuyVent;
        ventToggle.interactable = true;
    }

    public void VentActivate() {
        if (ventToggle.isOn){
            healthiness += 5;
        } else {
            healthiness -= 5;
        }
    }

    public void BuySky() {
        money -= costToBuySky;
        skyToggle.interactable = true;
    }

    public void SkyActivate() {
        if (skyToggle.isOn){
            healthiness += 10;
        } else {
            healthiness -= 10;
        }
    }

    public void BuyCage() {
        money -= costToBuyCage;
        cageToggle.interactable = true;
    }

    public void CageActivate() {
        if (cageToggle.isOn){
            healthiness -= 20;
            capacity *= 1.4f;
        } else {
            healthiness += 20;
            capacity /= 1.4f;
        }
    }

    public void BuyBigCage() {
        money -= costToBuyBigCage;
        bigCageToggle.interactable = true;
    }

    public void BigCageActivate() {
        if (bigCageToggle.isOn){
            healthiness -= 20;
            capacity *= 1.8f;
        } else {
            healthiness += 20;
            capacity /= 1.8f;
        }
    }
}
