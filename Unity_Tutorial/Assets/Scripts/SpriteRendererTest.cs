using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
}

public class SpriteRendererTest : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_Make;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

    private bool isDialogue = false;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void ShowDialogue()
    {
        //sprite_DialogueBox.gameObject.SetActive(true);
        //sprite_Make.gameObject.SetActive(true);
        //txt_Dialogue.gameObject.SetActive(true);
        OnOff(true);
        count = 0;
        //isDialogue = true;
        NextDialogue();
    }
    private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_Make.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }

    //private void HideDailogue()
    //{
    //    sprite_DialogueBox.gameObject.SetActive(false);
    //    sprite_Make.gameObject.SetActive(false);
    //    txt_Dialogue.gameObject.SetActive(false);
    //    isDialogue = false;
    //}

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_Make.sprite = dialogue[count].cg;
        count++;
    }

    private void Update()
    {
        if(isDialogue)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialogue.Length)
                {
                    NextDialogue();
                }
                else
                    OnOff(false);
                    //HideDialogue();
            }
        }
    }
}
