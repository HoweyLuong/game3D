using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    float hitPoints = 100f;
    public Score score;

    public void TakeDamage(float damage) {
        hitPoints -= damage;
        if(hitPoints <= 0) {
            
            KillEnemy();
        }
    }

    void KillEnemy() {
        if(score != null) {
            score.IncreaseScore(1);
        }
        Destroy(gameObject);
    }
}
