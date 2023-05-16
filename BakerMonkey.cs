using MelonLoader;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Models.TowerSets;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.TowerFilters;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2Cpp;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Utils;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using System.Linq;
using BTD_Mod_Helper.Api.Enums;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using BakerMonkey;
using UnityEngine;
using UnityEngine.Assertions;
using Il2CppAssets.Scripts.Models.Towers.Mods;

using Il2CppSystem.Collections.Generic;
using Il2CppAssets.Scripts.Unity.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using static BakerMonkeNameSpace.BakerMonkeyMod;

[assembly: MelonInfo(typeof(BakerMonkeNameSpace.BakerMonkeyMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
[assembly: MelonColor(160, 32, 240, 30)]
[assembly: MelonAuthorColor(160, 32, 240, 30)]




namespace BakerMonkeNameSpace
{




    public class BakerMonkeyMod : BloonsTD6Mod
    {



        public class bakerDisplay : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return true;
            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "bakertexture");
                SetMeshOutlineColor(node, new UnityEngine.Color(211, 211, 211));

            }
        }

        public class bakermiddleDisplay : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[1] == 1;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "bakertexturemiddle");
                SetMeshOutlineColor(node, new UnityEngine.Color(211, 211, 211));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }


        public class bakermiddleDisplayT2 : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[1] == 2;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "bakertexturemiddle");
                SetMeshOutlineColor(node, new UnityEngine.Color(211, 211, 211));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }


        public class bakermiddleDisplayT3 : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[1] == 3;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "bakertexturemiddle");
                SetMeshOutlineColor(node, new UnityEngine.Color(211, 211, 211));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }



        public class OvenLook : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[1] == 5;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "ovenlook");
                SetMeshOutlineColor(node, new UnityEngine.Color(255, 0, 0));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }


        public class OvenLookT4 : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[1] == 4;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "ovenlook");
                SetMeshOutlineColor(node, new UnityEngine.Color(255, 0, 0));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }


        public class BreadLookT1 : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[2] == 1;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "breadlook");
                SetMeshOutlineColor(node, new UnityEngine.Color(255, 0, 0));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }

        public class BreadLookT2 : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[2] == 2;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "breadlook");
                SetMeshOutlineColor(node, new UnityEngine.Color(255, 0, 0));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }


        public class BreadLookT3 : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[2] == 3;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "breadlook");
                SetMeshOutlineColor(node, new UnityEngine.Color(255, 0, 0));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }

        public class BreadLookT4 : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[2] == 4;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "breadlook");
                SetMeshOutlineColor(node, new UnityEngine.Color(255, 0, 0));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }

    }

    public class MegaBreadLook : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[2] == 5;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "megabreadlook");
                SetMeshOutlineColor(node, new UnityEngine.Color(255, 0, 0));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }


        public class CakeLookT1 : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[0] == 1;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "cakelook");
                SetMeshOutlineColor(node, new UnityEngine.Color(255, 255, 255));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }

        public class CakeLookT2 : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[0] == 2;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "cakelook");
                SetMeshOutlineColor(node, new UnityEngine.Color(255, 255, 255));

                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }


        public class CakeLookT3 : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[0] == 3;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "cakelook");
                SetMeshOutlineColor(node, new UnityEngine.Color(255, 255, 255));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }


        public class CakeLookT4 : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[0] == 4;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "cakelook");
                SetMeshOutlineColor(node, new UnityEngine.Color(255, 255, 255));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }


        public class CakeLookT5 : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers)
            {
                return tiers[0] == 5;

            }
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
#if DEBUG
                node.SaveMeshTexture();
                node.PrintInfo();

#endif

                SetMeshTexture(node, "cakelook");
                SetMeshOutlineColor(node, new UnityEngine.Color(255, 255, 255));
                node.RemoveBone("SuperMonkeyRig:Dart");

            }
        }



        public class BakerMonkey : ModTower
        {
            public override string Name => nameof(BakerMonkey);
            public override string DisplayName => "Baker Monkey";

            public override string Description => "bakes cake and other Things to support monkeys or make money thanks to norkasolka for the idea";

            public override string BaseTower => "BoomerangMonkey";

            public override int Cost => 750;

            public override int TopPathUpgrades => 5;

            public override int MiddlePathUpgrades => 5;

            public override int BottomPathUpgrades => 5;

            public override ParagonMode ParagonMode => ParagonMode.Base555;
            public override TowerSet TowerSet => TowerSet.Support;
            public override bool IsValidCrosspath(int[] tiers) => ModHelper.HasMod("UltimateCrosspathing") ? true : base.IsValidCrosspath(tiers);


            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                var attackModel = towerModel.GetAttackModel();


                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<PanDisplay>();
                towerModel.ApplyDisplay<bakerDisplay>();

            }

            public override string Icon => "BakerIcon";
            public override string Portrait => "BakerIcon";



        }

        public class Upgrade100 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "cake";

            public override string Description => "Bakes cake that has 2 pierce and 2 damage";

            public override int Cost => 180;

            public override int Path => 0;

            public override int Tier => 1;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var attackModel = towerModel.GetAttackModel();
                var WeaponModel = attackModel.weapons[0];
                var projectileModel = WeaponModel.projectile;
                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<CakeDisplay>();
                towerModel.ApplyDisplay<CakeLookT1>();
                projectileModel.pierce += 2;
                projectileModel.GetDamageModel().damage += 2;

            }

            public override string Icon => "cake";

            public override string Portrait => "cake";
        }

        public class Upgrade200 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "bigger cake";

            public override string Description => "the cake's get bigger and damage is now 5 but he gets slower";

            public override int Cost => 440;

            public override int Path => 0;

            public override int Tier => 2;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var attackModel = towerModel.GetAttackModel();
                var WeaponModel = attackModel.weapons[0];
                var projectileModel = WeaponModel.projectile;

                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<CakeDisplay>();
                towerModel.ApplyDisplay<CakeLookT2>();
                projectileModel.GetDamageModel().damage += 5;
            }

            public override string Icon => "BiggerCake";

            public override string Portrait => "BiggerCake";
        }

        public class Upgrade300 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "Bopped cake";

            public override string Description => " Bop! Bop! Your Toast! gives you less pierce but more damage";

            public override int Cost => 780;

            public override int Path => 0;

            public override int Tier => 3;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
            var attackModel = towerModel.GetAttackModel();
            var WeaponModel = attackModel.weapons[0];
            var projectileModel = WeaponModel.projectile;
            var projectile = attackModel.weapons[0].projectile;
            projectile.ApplyDisplay<CakeDisplay>();
            towerModel.ApplyDisplay<CakeLookT3>();
            projectileModel.pierce -= 5;
            projectileModel.GetDamageModel().damage += 10;

        }

            public override string Icon => "Boom";

            public override string Portrait => "Boom";
        }

        public class Upgrade400 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "delicious cake";

            public override string Description => "Boost monkeys in range with delicious cake";

            public override int Cost => 9730;

            public override int Path => 0;

            public override int Tier => 4;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var attackModel = towerModel.GetAttackModel();


                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<CakeDisplay>();
                towerModel.ApplyDisplay<CakeLookT4>();

                var rateSupportModel = new RateSupportModel("RateSupportModel_Genetic", 0.8f, true, Id, false, 0,
    new Il2CppReferenceArray<TowerFilterModel>(0), "", "");
                towerModel.AddBehavior(rateSupportModel);
                var support = new DamageTypeSupportModel("DamageTypeSupportModel_TempleBase", true, Id, BloonProperties.None,
       new Il2CppReferenceArray<TowerFilterModel>(0), "", "");
                towerModel.AddBehavior(support);

            }

            public override string Icon => "yummy";

            public override string Portrait => "yummy";
        }

        public class Upgrade500 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "the best cake";

            public override string Description => "This cake is so good that he makes every monkey 10× better";

            public override int Cost => 96690;

            public override int Path => 0;

            public override int Tier => 5;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var attackModel = towerModel.GetAttackModel();


                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<bestCakeDisplay>();
                towerModel.ApplyDisplay<CakeLookT5>();
                var rateSupportModel = new RateSupportModel("RateSupportModel_Genetic", 0.00000001f, true, Id, false, 0,
new Il2CppReferenceArray<TowerFilterModel>(0), "", "");
                towerModel.AddBehavior(rateSupportModel);



            }

            public override string Icon => "bestcake";

            public override string Portrait => "bestcake";
        }

        public class Upgrade010 : ModUpgrade<BakerMonkey>
        {
            public override string DisplayName => "cupcake";

            public override string Description => "Bakes cupcakes that have high pierce but low damage";

            public override int Cost => 300;

            public override int Path => 1;

            public override int Tier => 1;

            public override void ApplyUpgrade(TowerModel towerModel)
            {

                var attackModel = towerModel.GetAttackModel();
                var WeaponModel = attackModel.weapons[0];
                var projectileModel = WeaponModel.projectile;

                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<CupcakeDisplay>();

                projectileModel.pierce += 10;
                projectileModel.GetDamageModel().damage += 3;
            }

            public override string Icon => "cupcake";

            public override string Portrait => "cupcake";
        }

        public class Upgrade020 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "Double cupcakes";

            public override string Description => "Now bakes 1+ cup cake even higher pierce and can now See camo bloons";

            public override int Cost => 1500;

            public override int Path => 1;

            public override int Tier => 2;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var attackModel = towerModel.GetAttackModel();
                var WeaponModel = attackModel.weapons[0];
                var projectileModel = WeaponModel.projectile;
                towerModel.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 2, 50, 100f, null, false);
                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<CupcakeDisplay>();

                projectileModel.pierce += 20;
                projectileModel.GetDamageModel().damage += 2;
            towerModel.AddBehavior(new OverrideCamoDetectionModel("CamoTargeter", true));
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
        }

            public override string Icon => "Double";

            public override string Portrait => "Double";
        }

        public class Upgrade030 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "triple cupcakes";

            public override string Description => "Bakes 1+ and now has increased damage";

            public override int Cost => 1560;

            public override int Path => 1;

            public override int Tier => 3;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 3, 50, 100f, null, false);
                var attackModel = towerModel.GetAttackModel();
                var WeaponModel = attackModel.weapons[0];
                var projectileModel = WeaponModel.projectile;
                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<CupcakeDisplay>();

                projectileModel.GetDamageModel().damage += 10;
            }

            public override string Icon => "Triple";

            public override string Portrait => "Triple";
        }

        public class Upgrade040 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "oven";

            public override string Description => "pops leads";

            public override int Cost => 5120;

            public override int Path => 1;

            public override int Tier => 4;

            public override void ApplyUpgrade(TowerModel towerModel)
            {

                var attackModel = towerModel.GetAttackModel();
            var WeaponModel = attackModel.weapons[0];
            var projectileModel = WeaponModel.projectile;

            var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<OvenDisplay>();
                towerModel.ApplyDisplay<OvenLookT4>();

            projectileModel.GetDamageModel().immuneBloonProperties = BloonProperties.None;
        }

            public override string Icon => "oven";

            public override string Portrait => "oven";
        }

        public class Upgrade050 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "ultra super duper oven";

            public override string Description => "pops every bloon!";

            public override int Cost => 18830;

            public override int Path => 1;

            public override int Tier => 5;

            public override void ApplyUpgrade(TowerModel towerModel)
            {

                var attackModel = towerModel.GetAttackModel();
            var WeaponModel = attackModel.weapons[0];
            var projectileModel = WeaponModel.projectile;

            var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<OvenDisplay>();
                towerModel.ApplyDisplay<OvenLook>();

            projectileModel.GetDamageModel().immuneBloonProperties = BloonProperties.None;

        }

            public override string Icon => "megaoven";

            public override string Portrait => "megaoven";
        }

        public class Upgrade001 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "bread";

            public override string Description => "Throws bread that has lots of pierce";

            public override int Cost => 530;

            public override int Path => 2;

            public override int Tier => 1;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var attackModel = towerModel.GetAttackModel();


                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<BreadDisplay>();
                towerModel.ApplyDisplay<BreadLookT1>();
            var WeaponModel = attackModel.weapons[0];
            var projectileModel = WeaponModel.projectile;
            projectileModel.pierce += 10;
        }

            public override string Icon => "bread";

            public override string Portrait => "bread";
        }

        public class Upgrade002 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "Sandwich";

            public override string Description => "Throws A Sandwich which does x2 the pierce";

            public override int Cost => 1050;

            public override int Path => 2;

            public override int Tier => 2;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var attackModel = towerModel.GetAttackModel();


                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<BreadDisplay>();
                towerModel.ApplyDisplay<BreadLookT2>();
            var WeaponModel = attackModel.weapons[0];
            var projectileModel = WeaponModel.projectile;
            projectileModel.pierce += 20;
        }

            public override string Icon => "Sandwich";

            public override string Portrait => "Sandwich";
        }

        public class Upgrade003 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "bakery";

            public override string Description => "Now makes more Money x1.5";

            public override int Cost => 1260;

            public override int Path => 2;

            public override int Tier => 3;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var attackModel = towerModel.GetAttackModel();


                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<BreadDisplay>();
                towerModel.ApplyDisplay<BreadLookT3>();
            TowerModelBehaviorExt.AddBehavior<MonkeyCityIncomeSupportModel>(towerModel, new MonkeyCityIncomeSupportModel("MonkeyCityIncomeSupportModel_", true, 1.5f, (Il2CppReferenceArray<TowerFilterModel>)null, "MonkeyCityBuff", "BuffIconVillagexx4"));
        }

            public override string Icon => "BakeryIcon";

            public override string Portrait => "BakeryIcon";
        }

        public class Upgrade004 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "golden bakery";

            public override string Description => "Now every farm  gets  2×$";

            public override int Cost => 8020;

            public override int Path => 2;

            public override int Tier => 4;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var attackModel = towerModel.GetAttackModel();


                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<BreadDisplay>();
                towerModel.ApplyDisplay<BreadLookT4>();
                TowerModelBehaviorExt.AddBehavior<MonkeyCityIncomeSupportModel>(towerModel, new MonkeyCityIncomeSupportModel("MonkeyCityIncomeSupportModel_", true, 2f, (Il2CppReferenceArray<TowerFilterModel>)null, "MonkeyCityBuff", "BuffIconVillagexx4"));

            }

            public override string Icon => "Golden";

            public override string Portrait => "Golden";
        }

        public class Upgrade005 : ModUpgrade<BakerMonkey>
        {

            public override string DisplayName => "nuclear bakery";

            public override string Description => "Now every farm  gets  5×$\r\n";

            public override int Cost => 122500;

            public override int Path => 2;

            public override int Tier => 5;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var attackModel = towerModel.GetAttackModel();


                var projectile = attackModel.weapons[0].projectile;
                projectile.ApplyDisplay<MegaBreadDisplay>();
                towerModel.ApplyDisplay<MegaBreadLook>();
                TowerModelBehaviorExt.GetBehavior<MonkeyCityIncomeSupportModel>(towerModel).incomeModifier = 5f;
            }

            public override string Icon => "Nuclear";

            public override string Portrait => "Nuclear";
        }

        public class ParagonDisplay : ModTowerDisplay<BakerMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

            public override bool UseForTower(int[] tiers) => IsParagon(tiers);

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, "ParagonLook");

            SetMeshOutlineColor(node, new UnityEngine.Color(255, 255, 255));
            node.RemoveBone("SuperMonkeyRig:Dart");
        }

        public class UpgradeParagon : ModParagonUpgrade<BakerMonkey>
            {
                public override int Cost => 2000000;

                public override string Description => "Does Good Damage and Infinite Pierce also Boosts the Banana Farms by something????";

                public override string DisplayName => "Master Bakery";

                public override void ApplyUpgrade(TowerModel towerModel)
                {
                    var attackModel = towerModel.GetAttackModel();
                    var WeaponModel = attackModel.weapons[0];
                    var projectileModel = WeaponModel.projectile;


                    var projectile = attackModel.weapons[0].projectile;
                    projectile.ApplyDisplay<BakeryDisplay>();
                    towerModel.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 9, 50, 100f, null, false);

                    towerModel.GetWeapon().projectile.AddBehavior(new TrackTargetModel("Track", 99999, false, false, 9999, true, 99999, true, false));
                    TowerModelBehaviorExt.GetBehavior<MonkeyCityIncomeSupportModel>(towerModel).incomeModifier = 40f;
                    towerModel.AddBehavior(new OverrideCamoDetectionModel("CamoTargeter", true));
                    towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
                var rateSupportModel = new RateSupportModel("RateSupportModel_Genetic", 0.0001f, true, Id, false, 0,
new Il2CppReferenceArray<TowerFilterModel>(0), "", "");
                towerModel.AddBehavior(rateSupportModel);


                towerModel.GetAttackModel().range += 10;
                    towerModel.range += 10;
                    towerModel.radiusSquared += 10;


                    projectileModel.pierce = 99999;
                    projectileModel.GetDamageModel().damage = 99999;
                    projectileModel.GetDamageModel().immuneBloonProperties = BloonProperties.None;


                }

                public override string Icon => "Paragon";

                public override string Portrait => "Paragon";
            }
        }
    }
 
    


    


