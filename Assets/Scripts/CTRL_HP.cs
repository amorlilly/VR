using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CTRL_HP : MonoBehaviour
{
    private int maxHP = 100;
    private int currentHP;

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
        currentHP = maxHP;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            int damege = 10;

            currentHP = currentHP - damege;
            slider.value = (float) currentHP / (float) maxHP;
        }
    }
}
