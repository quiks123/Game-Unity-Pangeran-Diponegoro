using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject enemyPrefab;
    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    public GameObject playerPrefab2;
    public Transform playerBattleStation2;

    Unit playerUnit;
    Unit playerUnit2;
    Unit enemyUnit;

    public BattleState state;
    public Text dialogueText;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle(){
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Unit>();

        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGO.GetComponent<Unit>();

        GameObject player2GO = Instantiate(playerPrefab2, playerBattleStation2);
        playerUnit2 = player2GO.GetComponent<Unit>();

        dialogueText.text = "Selamat datang";

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;

        if (state = BattleState.PLAYERTURN)
        {
            dialogueText.text = "Giliran Player";
        }

        else if (state = BattleState.ENEMYTURN)
        {
            dialogueText.text = "Giliran Musuh";
        }
    }


    void PlayerTurn()
    {
        
    }

}
