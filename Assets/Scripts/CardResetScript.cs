using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardResetScript : MonoBehaviour
{
    private GameObject TarotCards;
    private int CardsCount; //カードの総数
    private int Random; //ランダム数

    GameControllerScript game_controller_script;
    // Start is called before the first frame update
    void Start()
    {
        game_controller_script = GameObject.FindWithTag("GameController").GetComponent<GameControllerScript>();
        //ゲームスタート時にカードを並び替える。
        RandomRun();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        //カードリセットボタンが押されたときの処理
        RandomRun();
    }

    private void RandomRun(){
        TarotCards = game_controller_script.TarotCards;
        CardsCount = TarotCards.transform.childCount;
        foreach(GameObject tarot_card in game_controller_script.TarotCardChildren){
            //まずすべてのゲームオブジェクトを表示させる
            tarot_card.SetActive(true);
        }
        for(int i = 0; i < CardsCount; i++){
            Random = UnityEngine.Random.Range(0, CardsCount); //0～カードの総数までのランダムな数字を生成する。
            TarotCards.transform.GetChild(i).gameObject.transform.SetSiblingIndex(Random); //↑でランダムな数字を生成した後、順番を入れ替える。

        }
        game_controller_script.CardDroppingCount = 0;
        game_controller_script.card_drop_script.CardDroppingCountUISet(game_controller_script.CardDroppingCount);
    }
}
