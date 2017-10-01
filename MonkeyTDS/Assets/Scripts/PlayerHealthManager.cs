using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public int startHealth;
    public float flashLength;

    int currentHealth;
    float flashCounter;
    Renderer rend;
    Color baseColor;

    void Start()
    {
        currentHealth = startHealth;
        rend = GetComponent<Renderer>();
        baseColor = rend.material.GetColor("_Color");
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }

        if (flashCounter > 0)
        {
            flashCounter -= Time.deltaTime;
            if (flashCounter <= 0)
            {
                rend.material.SetColor("_Color", baseColor);
            }
        }
    }

    public void HurtPlayer(int damage)
    {
        currentHealth -= damage;
        flashCounter = flashLength;

        rend.material.SetColor("_Color", Color.white);
    }
}
