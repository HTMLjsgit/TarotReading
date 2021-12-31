using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControllerScript : MonoBehaviour
{
    public GameObject ResultObjects; //カードをクリックしたら表示するオブジェクト
    public Image TarotResultImageUI; //カードの結果の画像を表示するためのImageオブジェクト
    public Text TarotResultTitleTextUI; //カードの結果のタイトルを表示するためのImageオブジェクト
    public Text TarotResultSentenceTextUI; //カードの結果の文章を表示するためのImageオブジェクト

    public GameObject TarotCards;
    public CardDropScript card_drop_script;
    public List<GameObject> TarotCardChildren;
    public int CardDroppingCount = 0; //引いた枚数
    public int CardsCount; //カードのデフォルトの総数
    public Scrollbar scrollbar;
    // Start is called before the first frame update
    void Start()
    {
        CardsCount = TarotCards.transform.childCount;
        foreach(Transform tarot_card in TarotCards.transform){
            TarotCardChildren.Add(tarot_card.gameObject);
        }
        scrollbar.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenTarotResult(Sprite TarotCardSprite, string TarotCardResultTitle, string TarotCardResultSentence){
        
        //カードの結果を開くときの関数
        this.ResultObjects.SetActive(true);

        this.TarotResultTitleTextUI.text = TarotCardResultTitle;
        this.TarotResultSentenceTextUI.text = TarotCardResultSentence;
        this.TarotResultImageUI.sprite = TarotCardSprite;
        
    }

    public void CloseTarotResult(){
        //カードの結果を閉じるときの関数
        this.ResultObjects.SetActive(false);

        this.TarotResultTitleTextUI.text = null;
        this.TarotResultSentenceTextUI.text = null;
        this.TarotResultImageUI.sprite = null;
    }

    
}
