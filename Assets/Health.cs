using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Transform place1;
    public Transform place2;
    public Transform place3;
    public GameObject HeartPrefab1;
    public GameObject HeartPrefab2;
    public GameObject HeartPrefab3;

    private void Start()
    {
        Instantiate((HeartPrefab1), place1.position, place1.rotation);
        Instantiate((HeartPrefab2), place2.position, place2.rotation);
        Instantiate((HeartPrefab3), place3.position, place3.rotation);
    }

    /*  [SerializeField] private float startingHealth;
      private float currentHealth;

      private void Awake()
      {
          currentHealth = startingHealth;
      }
      public void TakeDamage(float  _damage)
      {
          currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

          if (currentHealth > 0)
          {

          }
          else
          {

          }
      }
    */
}

