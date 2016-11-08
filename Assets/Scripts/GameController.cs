using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject player;
    public GameObject respawnPoint;

    public float fullHealth;
    public Slider healthSlider;
    float currentHealth;

    // Use this for initialization
    void Start () {

        currentHealth = fullHealth;
        healthSlider.maxValue = fullHealth;
        healthSlider.value = fullHealth;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RespawnPlayer()
    {
        player.gameObject.transform.position = respawnPoint.transform.position;
        currentHealth = fullHealth;
        healthSlider.maxValue = fullHealth;
        healthSlider.value = fullHealth;
    }

    public void Damage(float damage)
    {
        if (damage <= 0)
            return;
        currentHealth -= damage;
        healthSlider.value = currentHealth;


        if (currentHealth <= 0)
            RespawnPlayer();
    }
}
