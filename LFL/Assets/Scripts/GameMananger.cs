using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMananger : MonoBehaviour
{

    public static GameMananger Instance;

    public GameObject matchResultPannel;

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

        yield return new WaitForSeconds(3.0f);

        if(rand == 0)
        {
            Debug.Log(" 플레이어 유리 ");
        }
        else if(rand == 1)
        {
            Debug.Log(" 상대 유리 ");
        }

        yield return new WaitForSeconds(3.0f);

        matchResultPannel.SetActive(true);

        Debug.Log(" 매치 종료 ");

        yield return null;
    }

}
