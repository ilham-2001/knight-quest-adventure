using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    protected void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            col.GetComponent<PlayerHealth>().TakeDamage(1);
        }
    }
}
