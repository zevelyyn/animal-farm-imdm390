using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyingItems : MonoBehaviour
{
    public Button ethicalFoodTier1;
    public Button ethicalFoodTier2;
    public Button unethicalFoodTier1;
    public Button unethicalFoodTier2;
    public Button ethicalWarehouseTier1;
    public Button ethicalWarehouseTier2;
    public Button unethicalWarehouseTier1;
    public Button unethicalWarehouseTier2;
    public Button ethicalMachineTier1;
    public Button ethicalMachineTier2;
    public Button unethicalMachineTier1;
    public Button unethicalMachineTier2;
    public Button ethicalBusinessTier1;
    public Button ethicalBusinessTier2;
    public Button ethicalBusinessTier3;
    public Button unethicalBusinessTier1;
    public Button unethicalBusinessTier2;
    public Button unethicalBusinessTier3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // activate corn
        if (StatManager.money >= 50000 && !TechTree.HormoneBought) {
            ethicalFoodTier1.interactable = true;
        }
        // activate worm
        if (StatManager.money >= 90000 && TechTree.CornBought) {
            ethicalFoodTier2.interactable = true;
        }
        // activate growth hormone
        if (StatManager.money >= 50000 && !TechTree.CornBought) {
            unethicalFoodTier1.interactable = true;
        }
        // activate steroid
        if (StatManager.money >= 100000 && TechTree.HormoneBought) {
            unethicalFoodTier2.interactable = true;
        }


        // activate ventilation
        if (StatManager.money >= 50000 && !TechTree.CageBought) {
            ethicalWarehouseTier1.interactable = true;
        }
        // activate skylight
        if (StatManager.money >= 120000 && TechTree.VentilationBought) {
            ethicalWarehouseTier2.interactable = true;
        }
        // activate cage
        if (StatManager.money >= 30000 && !TechTree.VentilationBought) {
            unethicalWarehouseTier1.interactable = true;
        }
        // activate efficient cage
        if (StatManager.money >= 100000 && TechTree.CageBought) {
            unethicalWarehouseTier2.interactable = true;
        }


        // activate star stunner
        if (StatManager.money >= 100000 && !TechTree.Beheader3000Bought) {
            ethicalMachineTier1.interactable = true;
        }
        // activate halal execution
        if (StatManager.money >= 300000 && TechTree.StunnerBought) {
            ethicalMachineTier2.interactable = true;
        }
        // activate beheader 3000
        if (StatManager.money >= 80000 && !TechTree.StunnerBought) {
            unethicalMachineTier1.interactable = true;
        }
        // activate beheader 5000
        if (StatManager.money >= 120000 && TechTree.Beheader3000Bought) {
            unethicalMachineTier2.interactable = true;
        }


        // activate local farmer market
        if (TechTree.CornBought && TechTree.VentilationBought && StatManager.health > 50) {
            ethicalBusinessTier1.interactable = true;
        }
        // activate trader joes
        // Debug.Log(TechTree.LocalMarketBought.ToString() + TechTree.WormBought.ToString() + TechTree.SkylightBought.ToString() + TechTree.StunnerBought.ToString() + StatManager.health.ToString());
        if (TechTree.LocalMarketBought && TechTree.WormBought && TechTree.SkylightBought && TechTree.StunnerBought && StatManager.health > 75) {
            ethicalBusinessTier2.interactable = true;
        }
        // activate whole foods
        if (TechTree.TraderJoesBought && TechTree.StunnerBought && StatManager.health > 90) {
            ethicalBusinessTier3.interactable = true;
        }
        // activate five below
        if (TechTree.HormoneBought && TechTree.CageBought) {
            unethicalBusinessTier1.interactable = true;
        }
        // activate walmart
        if (TechTree.FiveBelowBought && TechTree.SteroidBought && TechTree.EfficientBought && TechTree.Beheader3000Bought) {
            unethicalBusinessTier2.interactable = true;
        }
        // activate mcdonalds
        if (TechTree.WalmartBought && TechTree.Beheader5000Bought) {
            unethicalBusinessTier3.interactable = true;
        }
    }

}
