using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMananger : MonoBehaviour
{

    public static GameMananger Instance;

    public GameObject inGamePannel;
    public GameObject matchResultPannel;

    public List<Unit> playerUnit = new List<Unit>();
    public List<Unit> oppositeUnit = new List<Unit>();

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
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

}
