using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Transform canvasTransform;
    public GameObject enemyPrefab;

    private Player player;
    private Enemy selectedEnemy;
    //private TouchScreenKeyboard playerKeyboard;
    private float enemyTargetLine;

   
   



    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        // playerKeyboard = player.keyboard;
        /*GameObject enemyInstance = Instantiate(enemyPrefab);
        enemyInstance.transform.SetParent(canvasTransform);
        enemyInstance.transform.position = new Vector2(enemyInstance.transform.position.x, 6.28f);
        selectedEnemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();*/
        InvokeRepeating("EnemySpawner", 0, 5f);

    }

    private void Update()
    {
        
        /*if(player.textInput==selectedEnemy.str)
        {
            Debug.Log("HIT");
            selectedEnemy.speed = 0f;
        }*/

        


    }
    private void EnemySpawner()
    {
        GameObject enemyInstance = Instantiate(enemyPrefab);
        enemyInstance.transform.SetParent(canvasTransform);
        float x = Random.Range(-2.4f, 3.2f);
        enemyInstance.transform.position = new Vector2(x, 6.28f);
        //Add code for random words and it being displayed
        string hey = "HEY";
        enemyInstance.GetComponent<Enemy>().setValues(hey);//display
       // yield return new WaitForSeconds(3f);
    }
}
