using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CTRL_S_HP : MonoBehaviour
{
    public Image HPbar;

    public float maxHP = 100;

    private float current;
    // Start is called before the first frame update
    void Start()
    {
        //HPbar = GetComponent<Image>();
        HPbar.fillAmount = 1;

        current = maxHP;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            int damege = 10;

            current = current - damege;
            HPbar.fillAmount = (float)current / (float)maxHP;
            
        }
    }
}
