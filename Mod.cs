using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace JYZDLCToMainNS
{
    public class JYZDLCToMain : Mod
    {
        public override void Ready()
        {
            //基础蓝图
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicIdea, "blueprint_rope2", 1);
            //基础建筑蓝图
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicBuildingIdea, "blueprint_animal_cage", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicBuildingIdea, "blueprint_barrel", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicBuildingIdea, "blueprint_naming_stone", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicBuildingIdea, "blueprint_painting", 1);
            //进阶建筑蓝图
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "blueprint_book", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "blueprint_flour_mill", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "blueprint_oven", 1);
            //食物蓝图
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "blueprint_beer", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "blueprint_bread", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "blueprint_cheese", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "blueprint_dough", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "blueprint_flour", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "blueprint_french_fries", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "blueprint_roasted_meat", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "blueprint_fruitsalad_2", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "blueprint_grape_pulp", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "blueprint_milkshake_2", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "blueprint_pancakes", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "blueprint_wine", 1);
            //装备蓝图
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.EquipmentBlueprints, "blueprint_wool_dress", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.EquipmentBlueprints, "blueprint_jester_hat", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.EquipmentBlueprints, "blueprint_plague_mask", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.EquipmentBlueprints, "blueprint_wool_socks", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.EquipmentBlueprints, "blueprint_scythe", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.EquipmentBlueprints, "blueprint_throwing_tomatos", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.EquipmentBlueprints, "blueprint_winter_coat", 1);
            //岛屿食物蓝图
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_CookingIdea, "blueprint_card_fish_chips", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_CookingIdea, "blueprint_roasted_fish", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_CookingIdea, "blueprint_olive_oil", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_CookingIdea, "blueprint_olive_pulp", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_CookingIdea, "blueprint_pizza", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_CookingIdea, "blueprint_royal_banquet", 1);
            //岛屿基础蓝图
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_BasicIdea, "blueprint_paper", 1);

            //岛屿进阶建筑蓝图
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_AdvancedBuildingIdea, "blueprint_well", 1);

            //基础食物
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicFood, "wheat", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicFood, "grape", 1);
            //基础收获
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicHarvestable, "tomato_plant", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicHarvestable, "apple_tree", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicHarvestable, "grape_vine", 1);
            //进阶敌人
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedEnemy, "feral_cat", 1);
            //进阶材料
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedResources, "book", 1);
            //进阶收获
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedHarvestable, "ruins", 1);
            //动物
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Animal, "sheep", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Animal, "horse", 1);
            //岛屿基础收获
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_BasicHarvestable, "olive", 1);
            //岛屿进阶收获
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_AdvancedHarvestable, "ruins", 1);
            //岛屿基础食物
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_BasicFood, "olive_tree", 1);
            //岛屿基础敌人
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_BasicEnemy, "feral_cat", 1);

            //基础敌人 BasicEnemy
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicEnemy, "ghoul", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicEnemy, "imp", 1);
            //进阶敌人 AdvancedEnemy
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedEnemy, "fiend", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedEnemy, "royal_archer", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedEnemy, "royal_guard", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedEnemy, "royal_mage", 1);
            //岛屿基础敌人 Island_BasicEnemy
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_BasicEnemy, "ghoul", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Island_BasicEnemy, "imp", 1);
            //岛屿进阶敌人 Island_AdvancedEnemy
            //森林基础敌人 Forest_BasicEnemy
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Forest_BasicEnemy, "ghoul", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Forest_BasicEnemy, "fiend", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Forest_BasicEnemy, "imp", 1);
            //森林进阶敌人 Forest_AdvancedEnemy
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Forest_AdvancedEnemy, "royal_archer", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Forest_AdvancedEnemy, "royal_guard", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Forest_AdvancedEnemy, "royal_mage", 1);



        }
    }
}