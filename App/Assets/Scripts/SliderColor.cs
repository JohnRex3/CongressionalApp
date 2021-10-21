using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderColor : MonoBehaviour
{
    public Image HealthBar;

    float health, maxHealth = 100;
    float lerpSpeed; 




    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health > maxHealth) health = maxHealth;

        HealthBarFiller();
        ColorChanger();


        lerpSpeed = 3f * Time.deltaTime;
    }

    void HealthBarFiller()
    {
        HealthBar.fillAmount = Mathf.Lerp(HealthBar.fillAmount, health/maxHealth, lerpSpeed);
    }

    void ColorChanger()
    {
        Color healthColor = Color.Lerp(Color.red, Color.green, (health / maxHealth));


        HealthBar.color = healthColor;
    }


    public void Damage(float damagePoints)
    {
        if (health > 0)
            health -= damagePoints;
    }

    public void Heal(float healingPoints)
    {
        if (health < maxHealth)
            health += healingPoints; 
    }
}
