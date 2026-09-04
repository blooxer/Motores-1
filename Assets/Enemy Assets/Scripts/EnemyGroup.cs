using System.Collections.Generic;
using UnityEngine;

public class EnemyGroup : MonoBehaviour
{
    [SerializeField] List<Enemy> enemies = new List<Enemy>();

    Enemy attackingEnemie;


    private void Start()
    {
        enemies.AddRange(GetComponentsInChildren<Enemy>());
   
    }
    public bool CanAttack(Enemy enemy)
    {
        return attackingEnemie == null || attackingEnemie == enemy;
    }

    public void StartAttack(Enemy enemy)
    {
        if(attackingEnemie == null)
        {
            attackingEnemie = enemy;
        }
    }

    public void FinishAttack(Enemy enemy)
    {
        if (attackingEnemie == enemy)
        {
            attackingEnemie = null;
        }
    }

}
