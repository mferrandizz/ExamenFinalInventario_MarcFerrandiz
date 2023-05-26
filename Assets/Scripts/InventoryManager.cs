using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    
    public static InventoryManager Instance;

    public ScripteableObjetos[] weapons;
    public ScripteableObjetos[] shields;

    public Text[] weaponsText;
    public Image[] weaponsSprite;

    public Text[] shieldsText;
    public Image[] shieldsSprite;


    void Awake()
    {
        Instance = this;
    }

    public void AddWeapon(ScripteableObjetos weapon)
    {
        for(int i = 0; i < weapons.Length; i++)
        {
            if(weapon.weaponType == 0)
            {
                if(weapons[i] == null)
                {
                    weapons[i] = weapon;
                    weaponsText[i].text = weapon.weaponName;
                    weaponsSprite[i].sprite = weapon.weaponSprite;
                    
                    return;

                }
            }
            if(weapon.weaponType == 1)
            {
                if(shields[i] == null)
                {
                    shields[i] = weapon;
                    shieldsText[i].text = weapon.weaponName;
                    shieldsSprite[i].sprite = weapon.weaponSprite;

                    return;

                }
            }

        }
    }
    

}
