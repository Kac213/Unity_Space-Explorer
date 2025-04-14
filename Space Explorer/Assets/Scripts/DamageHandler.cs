using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public float health = 1.0f;
    float invulnTimer = 0;
    public float invulnPeriod = 0;
    int correctLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        correctLayer = gameObject.layer;
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger");
        health--;
        invulnTimer = invulnPeriod;
        gameObject.layer = 8;
    }

    // Update is called once per frame
    void Update()
    {
        invulnTimer -= Time.deltaTime;
        if (invulnTimer <= 0)
        {
            gameObject.layer = correctLayer;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
