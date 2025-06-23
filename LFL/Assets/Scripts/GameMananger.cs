using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMananger : MonoBehaviour
{

    public static GameMananger Instance;

    public GameObject inGamePannel;
    public GameObject matchResultPannel;

    public Unit playerUnit;

    public Unit otherUnit;

    private int rand;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    public void PlayingMatch()
    {
        rand = Random.Range(0, 2);

        StartCoroutine(PlayingMatchCo());
    }

    public IEnumerator PlayingMatchCo()
    {

        Debug.Log(" 매치 시작 ");

        inGamePannel.SetActive(true);

        yield return new WaitForSeconds(2.0f);

       // playerUnit.SetHealth(otherUnit.GetAttackPoint() - playerUnit.GetDefencePoint());

      //  otherUnit.SetHealth(playerUnit.GetAttackPoint() - otherUnit.GetDefencePoint());

        yield return new WaitForSeconds(2.0f);

        inGamePannel.SetActive(false);

        matchResultPannel.SetActive(true);

        Debug.Log(" 매치 종료 ");

        Debug.Log(" 플레이어 체력 : " + playerUnit.GetHealth());

        Debug.Log(" 상대편 체력 : " + otherUnit.GetHealth());

        yield return null;
    }

}
