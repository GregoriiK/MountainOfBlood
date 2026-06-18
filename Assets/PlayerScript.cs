using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int maxHp = 150;
    public int hp = 100;
    public int stamina = 100;
    [SerializeField] Image hpBarImage;
    void Start()
    {
        UpdateHpBar();
    }

    public void UpdateHpBar()
    {
        hpBarImage.fillAmount = (float)hp/(float)maxHp;
    }

    public void HpManager(int hpAmount)
    {
        hp += hpAmount;
        if (hp <= 0)
        {
            Debug.Log("You died");
        }
        if (hp < maxHp)
        {
            hp = maxHp;
        }
        UpdateHpBar();
    }
    
}
