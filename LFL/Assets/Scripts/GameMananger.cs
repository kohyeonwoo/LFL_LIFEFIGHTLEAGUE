using System.Collections;
using System.Collections.Generic;
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

    public float totalPlayerUnitsAttackPoint;
    public float totalOtherTeam1UnitsAttackPoint;
    public float totalOtherTeam2UnitsAttackPoint;
    public float totalOtherTeam3UnitsAttackPoint;
    public float totalOtherTeam4UnitsAttackPoint;
    public float totalOtherTeam5UnitsAttackPoint;

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
        StartCoroutine(PlayingMatchCo());
    }

    public IEnumerator PlayingMatchCo()
    {

        Debug.Log(" 매치 시작 ");

        inGamePannel.SetActive(true);

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

}
