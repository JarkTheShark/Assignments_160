using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private EnemyData EnemyData;

    void Start()
    {
        print(EnemyData.EnemyName1 + " has " + EnemyData.EnemyHealth1 + " health. They do " + EnemyData.EnemyDamage1
             + " damage by " + EnemyData.EnemyDescription1);
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if (EnemyData.EnemyHealth1 >= 0)
            {
                EnemyData.Attacked(50);
                if (EnemyData.EnemyHealth1 < 0)
                {
                    print("You have killed the enemy! Yippee!");
                }
            }
        }
    }
}
