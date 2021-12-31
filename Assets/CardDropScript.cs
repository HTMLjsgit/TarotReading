using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDropScript : MonoBehaviour
{


    GameControllerScript game_controller_script;

    private Text my_textUI;
    // Start is called before the first frame update
    void Start()
    {
        my_textUI = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CardDroppingCountUISet(int count){
        my_textUI.text = ("引いた枚数: " + (count).ToString());
    }
}
