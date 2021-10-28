using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    public EmsPadController EmsPad;

    public int Damage;

    public float duration = 2.0f;

    public float deltaTime;

    // Start is called before the first frame update
    void Start()
    {
        deltaTime = 0;
        Damage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += Time.deltaTime;

        if (deltaTime < duration) return;

        deltaTime = 0;

        // Debug.Log($"{Damage}");

        if (Damage > 0)
        {
            Damage--;
            Damage = Mathf.Clamp(Damage, 0, 10);

            EmsPad.Strength = Damage;
        }
        else
        {
            EmsPad.Reset();
        }
    }

    public void AddDamage()
    {
        Damage++;
    }

    public void AddDamage(int value)
    {
        Damage += value;
    }

    public void SetDamage(int value)
    {
        Damage = value;
    }
}
