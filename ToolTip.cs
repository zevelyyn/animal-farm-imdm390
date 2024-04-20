using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour
{
    private Text tooltipText;
    private RectTransform backgroundRectTransform;
    public RectTransform currRectTransform;
    public RectTransform canvaseRectTransform;

    private void Awake() {
        backgroundRectTransform = transform.Find("Panel").GetComponent<RectTransform>();
        tooltipText = transform.Find("Text").GetComponent<Text>();

        // SetText("Hello world");
        // ShowTooltip("random tofdbkjsgdsjkbfjsnjfdknskjfndsj");
        // Debug.Log(tooltipText.preferredWidth.ToString());
        HideTooltip();
    }

    private void ShowTooltip (string tooltipString) {
        gameObject.SetActive(true);

        Vector2 textPaddingSize = new Vector2(15, 15);
        tooltipText.text = tooltipString;
        Vector2 backgroundSize = new Vector2(tooltipText.preferredWidth, tooltipText.preferredHeight);
        backgroundRectTransform.sizeDelta = backgroundSize + textPaddingSize;
        // tooltipText.RectTransform.sizeDelta = backgroundRectTransform.sizeDelta;
    }

    public void HideTooltip() {
        gameObject.SetActive(false);
    }

    public void Update() {
        currRectTransform.anchoredPosition = Input.mousePosition / canvaseRectTransform.localScale.x;
    }

    public void SoyPalletDescription() {
        ShowTooltip("Default: Soy Pallet");
    }

    public void OrganicCornDescription() {
        ShowTooltip("Ethical Upgrade Tier 1: Organic Corn\nChicken health +5%\nBreeding rate +2%\n\nRequirement:\nCost: $50,000\nOperational cost: $800/day");
    }

    public void OrganicWormDescription() {
        ShowTooltip("Ethical Upgrade Tier 2: Organic Worm\nChicken health +15%\nBreeding rate +5%\n\nRequirement:\nEthical Food Tier 1 Unlocked\nCost: $90,000\nOperational cost: $2000/day");
    }

    public void GrowthHormoneDescription() {
        ShowTooltip("Unethical Upgrade Tier 1: Growth Hormone\nChicken health -5%\nBreeding rate +10%\n\nRequirement:\nCost: $30,000\nOperational cost: $600/day");
    }

    public void SteroidDescription() {
        ShowTooltip("Unethical Upgrade Tier 2: Steroid\nChicken health -50%\nBreeding rate +80%\n\nRequirement:\nUnethical Food Tier 1 Unlocked\nCost: $100,000\nOperational cost: $1,000/day");
    }

    public void WarehouseDescription() {
        ShowTooltip("Default: Warehouse");
    }

    public void VentilationDescription(){
        ShowTooltip("Ethical Upgrade Tier 1: Ventilation\nChicken health +5%\n\nRequirement:\nCost: $50,000\nOperational cost: $1,000/day");
    }

    public void SkylightDescription() {
        ShowTooltip("Ethical Upgrade Tier :2 Skylight\nChicken health +10%\n\nRequirement:\nEthical Warehouse Tier 1 Unlocked\nCost: $120,000\nOperational cost: $500/day");
    }

    public void CageDescription() {
        ShowTooltip("Unethical Upgrade Tier 1: Cage\nChicken health -20%\nWarehouse Capacity +40%\n\nRequirement:\nCost: $30,000\nOperational cost: $800/day");
    }

    public void EfficientCageDescription() {
        ShowTooltip("Unethical Upgrade Tier 2: Efficient Cage\nWarehouse Capacity +80%\n\nRequirement:\nCost: $100,000\nOperational cost: $1,800/day");
    }

    public void Beheader1000Description() {
        ShowTooltip("Default: Beheader 1000");
    }

    public void StunnerDescription() {
        ShowTooltip("Ethical Upgrade Tier 1: Star Stunner\nEnables Tier 2: Ethical business decision\n\nRequirement:\nCost: $100,000\nOperational cost: $1,200/day");
    }

    public void HalalDescription() {
        ShowTooltip("Ethical Upgrade Tier 2: Halal Execution\nEnables Tier 3: Ethical business decision\n\nRequirement:\nCost: $300,000\nOperational cost: $5,000/day");
    }

    public void Beheader3000Description() {
        ShowTooltip("Unethical Upgrade Tier 1: Beheader 3000\nEnables Tier 2: Unethical business decision\n\nRequirement:\nCost: $80,000\nOperational cost: $1,500/day");
    }

    public void Beheader5000Description() {
        ShowTooltip("Unethical Upgrade Tier 2: Beheader 5000\nEnables Tier 3: Unethical business decision\n\nRequirement:\nCost: $120,000\nOperational cost: $2,000/day");
    }

    public void LocalMarketDescription() {
        ShowTooltip("Tier 1: We are farmers - Joseph is able to sell in his local farmer’s market.\nRate of chicken sold: +5%\n\nRequirements:\nEthical food tier 1 unlocked\nEthical warehouse tier 1 unlocked\nChicken healthiness is above 50%");
    }

    public void TraderJoesDescription() {
        ShowTooltip("Tier 2: For the Regular Joes\nRate of chicken sold: +15%\nPrice per chicken sold: +10%\n\nRequirements:\nEthical food tier 2 unlocked\nEthical warehouse tier 2 unlocked\nEthical machine tier 1 unlocked\nChicken healthiness is above 75%");
    }

    public void WholeFoodsDescription() {
        ShowTooltip("Tier 3: Bezos to the rescue\nRate of chicken sold: +100%\nPrice per chicken sold: +20%\n\nRequirements:\nEthical food tier 2 unlocked\nEthical warehouse tier 2 unlocked\nEthical machine tier 2 unlocked\nChicken healthiness is above 90%");
    }

    public void FiveBelowDescription() {
        ShowTooltip("Tier 1: Five Below\nRate of chicken sold: +25%\n\nRequirements:\nUnethical food tier 1 unlocked\nUnethical warehouse tier 1 unlocked");
    }

    public void WalmartDescription() {
        ShowTooltip("Tier 2: Walmart\nRate of chicken sold: +25%\n\nRequirements:\nUnethical food tier 2 unlocked\nUnethical warehouse tier 2 unlocked\nUnethical machine tier 1 unlocked");
    }

    public void McDonaldsDescription() {
        ShowTooltip("Tier 3: McNuggies\nRate of chicken sold: +300%\n\nRequirements:\nUnethical food tier 2 unlocked\nUnethical warehouse tier 2 unlocked\nUnethical machine tier 2 unlocked");
    }
}
