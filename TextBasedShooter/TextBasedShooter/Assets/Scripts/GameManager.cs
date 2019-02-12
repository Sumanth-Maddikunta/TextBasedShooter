using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Transform canvasTransform;
    public GameObject enemyPrefab;
    public InputField inputField;

    private List<Enemy> enemyList;
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
        SelectEnemy();
        // Debug.Log(selectedEnemy.transform.position);
        if (selectedEnemy != null)
        {
            if (string.Compare(player.textInput, selectedEnemy.str) == 1)
            {
                Debug.Log("TextMatch");
                Destroy(selectedEnemy.gameObject);
            }
        }
        else
        {
            Debug.Log("Enemy is null");
        }
        foreach(Enemy enemy in enemyList)
        {
            Debug.Log("Enemy Count" + enemyList.Count);
            if(enemy.transform.position.y<inputField.transform.position.y)
            {
                enemyList.Remove(enemy);
                Destroy(enemy.gameObject);
            }
        }
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

    void SelectEnemy()
    {
        foreach(Enemy enemy in canvasTransform.GetComponentsInChildren<Enemy>())
        {
            enemyList.Add(enemy);
            if(selectedEnemy==null)
            {
                Debug.Log("Enemy was Empty");
                selectedEnemy = enemy;
            }
            
        }
    }
}
