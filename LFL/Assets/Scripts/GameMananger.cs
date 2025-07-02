using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameMananger : MonoBehaviour
{

    public static GameMananger Instance;

    //인 게임 패널 관련 오브젝트 모음 

    public GameObject inGamePannel;
    public GameObject matchResultPannel;
    public GameObject buttonSpawnPannel;

    // 플레이어 & 상대방 & 전체 유닛 List 모음

    public List<Unit> allUnits = new List<Unit>();
    public List<Unit> playerUnit = new List<Unit>();
    public List<Unit> oppositeUnit = new List<Unit>();

    //구매 버튼 UI 관련 List

    public List<GameObject> buyButtons = new List<GameObject>();

    //플레이어 전체 공격력 / 방어력 / 체력 모음 

    public int totalPlayerUnitsAttackPoint;
    public int totalPlayerUnitDefencePoint;
    public int totalPlayerUnitsHealth;

    //상대방 전체 공격력 / 방어력 / 체력 모음 

    public int oppositeUnitsAttackPoint;
    public int oppositeUnitsDefencePoint;
    public int oppositeUnitsHealthPoints;

    // 플레이어 / 상대방이 받을 최종 피해

    public int forPlayerDamage;
    public int forOppositeDamage;

    // 플레이어 / 상대방들 승점용 변수

    public int playerWinPoint;
    public int opposite1WinPoint;
    public int opposite2WinPoint;
    public int opposite3WinPoint;

    // 랭킹 관련 위치 
    public Transform ranking1Transform;

    public List<Text> teamText = new List<Text>();


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

        SetRanking();
    }

    //경기 시작 

    public void PlayingMatch()
    {

        //현재 플레이어 유닛 수에 맞게 상대방 유닛 수가 상대방 유닛 List에 더해진다

        for(int i =0; i < playerUnit.Count; i++)
        {

            int rand = Random.Range(0, allUnits.Count);

            oppositeUnit.Add(allUnits[rand]);

        }

        oppositeUnitsAttackPoint = Random.Range(Random.Range(1,4), totalPlayerUnitsAttackPoint + 3);
        oppositeUnitsDefencePoint = Random.Range(Random.Range(1, 4), totalPlayerUnitDefencePoint + 3);
        oppositeUnitsHealthPoints = Random.Range(Random.Range(1, 4), totalPlayerUnitsHealth + 3);


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

    //구매 버튼 UI가 생성된다 --> 9개
    public void SpawnBuyButtons()
    {
        for(int i =0; i < 9; i++)
        {
            Instantiate(buyButtons[0], buttonSpawnPannel.transform);
        } 
    }

    //경기 후 결과 및 랭킹 세팅
    public void SetRanking()
    {
        if(playerWinPoint  > opposite1WinPoint && playerWinPoint > opposite2WinPoint 
            && playerWinPoint > opposite3WinPoint)
        {
            teamText[0].transform.position = ranking1Transform.position;
        }
    }

    //경기 끝난 후 화면 돌아가기

    public void GoNextMatch()
    {
        SceneManager.LoadScene("GameScene");
    }

}
