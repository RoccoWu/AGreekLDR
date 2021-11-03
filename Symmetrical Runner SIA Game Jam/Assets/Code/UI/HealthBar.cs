using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public int health;
    public int maxHealth = 100;

    void Start()
    {
        slider.maxValue = maxHealth;
        slider.value = health;
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        slider.value -= damage;
        health = (int)slider.value;
        Debug.Log("Owie! Meesa health is " + slider.value);
    }
}
