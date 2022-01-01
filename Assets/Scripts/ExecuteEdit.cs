using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class ExecuteEdit : MonoBehaviour
{
    public bool Run;
    public GameObject TarotCards;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Run){
            foreach(Transform t in TarotCards.transform){
                TarotScript tarot_script = t.GetComponent<TarotScript>();
                if(tarot_script != null){
                    if(tarot_script.TarotResultSentence.Contains("test")){
                        Debug.Log(t.gameObject.name);
                    }
                }
            }
            Run = false;
        }
    }
}
