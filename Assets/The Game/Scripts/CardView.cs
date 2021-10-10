using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardView : MonoBehaviour
{
    public Text title;
    public Text description;
    public Text inExhibit;
    public Image animalImg;

    public CardModel[] cards;

    public void DisplayCard(int card)
    {
        title.text = cards[card].title;
        description.text = cards[card].description;
        inExhibit.text = cards[card].exhibit;
        animalImg.sprite = cards[card].animalImg;
    }
}
