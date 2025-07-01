using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMananger : MonoBehaviour
{

    public static GameMananger Instance;

    public GameObject inGamePannel;
    public GameObject matchResultPannel;
    public GameObject buttonSpawnPannel;

    public List<Unit> allUnits = new List<Unit>();
    public List<Unit> playerUnit = new List<Unit>();
    public List<Unit> oppositeUnit = new List<Unit>();

    public List<GameObject> buyButtons = new List<GameObject>();

    public int totalPlayerUnitsAttackPoint;
    public int totalPlayerUnitDefencePoint;
    public int totalPlayerUnitsHealth;
        
    public int oppositeUnitsAttackPoint;
    public int oppositeUnitsDefencePoint;
    public int oppositeUnitsHealthPoints;

    public int forPlayerDamage;
    public int forOppositeDamage;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        SpawnBuyButtons();
    }

    public void PlayingMatch()
    {

        for(int i =0; i < playerUnit.Count; i++)
        {
            int rand = Random.Range(0, allUnits.Count);

            oppositeUnit.Add(allUnits[rand]);

        }

        oppositeUnitsAttackPoint = Random.Range(1 + 3, totalPlayerUnitsAttackPoint + 3);
        oppositeUnitsDefencePoint = Random.Range(1 + 3, totalPlayerUnitDefencePoint + 3);
        oppositeUnitsHealthPoints = Random.Range(1 + 3, totalPlayerUnitsHealth + 3);


        StartCoroutine(PlayingMatchCo());

    }

    public IEnumerator PlayingMatchCo()
    {

        Debug.Log(" 매치 시작 ");

        inGamePannel.SetActive(true);

        yield return new WaitForSeconds(4.0f);

        forPlayerDamage = oppositeUnitsAttackPoint - totalPlayerUnitDefencePoint;

        forOppositeDamage = totalPlayerUnitsAttackPoint - oppositeUnitsDefencePoint;

        yield return new WaitForSeconds(4.0f);

        if(forPlayerDamage <= 0 || forOppositeDamage <= 0)
        {
            Debug.Log("비김");
        }
        else
        {
            if(forPlayerDamage > 0 && forOppositeDamage < 0)
            {
                totalPlayerUnitsHealth -= forPlayerDamage;
            }
            else if(forPlayerDamage < 0 && forOppositeDamage > 0)
            {
                oppositeUnitsHealthPoints -= forOppositeDamage;
            }

            if (totalPlayerUnitsHealth > oppositeUnitsHealthPoints)
            {
                Debug.Log("플레이어 승리");
            }
            else if(totalPlayerUnitsHealth < oppositeUnitsHealthPoints)
            {
                Debug.Log("상대방 승리");
            }
        }

        yield return new WaitForSeconds(1.0f);

        inGamePannel.SetActive(false);

        matchResultPannel.SetActive(true);

        Debug.Log(" 매치 종료 ");

    }

    public void SpawnBuyButtons()
    {
        for(int i =0; i < 9; i++)
        {
            Instantiate(buyButtons[0], buttonSpawnPannel.transform);
        } 
    }

    public void CurrentPlayerUnitStats()
    {
        Debug.Log("플레이어 팀 현재 체력 : " + totalPlayerUnitsHealth);
        Debug.Log("플레이어 팀 현재 공격력 : " + totalPlayerUnitsAttackPoint);
        Debug.Log("플레이어 팀 현재 방어력 : " + totalPlayerUnitDefencePoint);
    }

    public void GoNextMatch()
    {
        SceneManager.LoadScene("GameScene");
    }

}
