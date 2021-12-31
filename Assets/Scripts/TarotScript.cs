using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarotScript : MonoBehaviour
{
    [Header("タロット占いの結果")]
    public string TarotTitle; //タロット占いカードのタイトル
    [TextArea(1,3)]
    public string TarotResultSentence; //タロット占いカードの文章
    public Sprite TarotCardSprite; //タロット占いカードの画像
    GameControllerScript game_controller_script;
    // Start is called before the first frame update
    void Start()
    {
        game_controller_script = GameObject.FindWithTag("GameController").GetComponent<GameControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        //カードを引くときの関数

        //GameControllerScriptのOpenTarotResult関数を実行する。
        game_controller_script.OpenTarotResult(TarotCardSprite: this.TarotCardSprite, TarotCardResultTitle: this.TarotTitle,
                                               TarotCardResultSentence: this.TarotResultSentence);
        //OpenTarotResultの引数に自分のカードの値を入れていく。

        //引いた枚数を増やし引いた枚数の数字を描画する。
        game_controller_script.CardDroppingCount++;
        game_controller_script.card_drop_script.CardDroppingCountUISet(game_controller_script.CardDroppingCount);
        
        //一枚引けば、一枚泣くなるので自分のオブジェクトを非表示にする。
        this.gameObject.SetActive(false);
    }
}
