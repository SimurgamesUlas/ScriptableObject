using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
public class Card1 : MonoBehaviour
{
    public Card card;
    
    public TextMeshProUGUI cardName;

    public TextMeshProUGUI cardDescription;
    
    public UnityEngine.UI.Image cardArtWork;

    public TextMeshProUGUI cardMana;

    public TextMeshProUGUI CardAttacak;

    public TextMeshProUGUI CardHealth;
    void Start()
    {
        cardName.text = card.name;
        cardDescription.text = card.description;
        cardArtWork.sprite = card.artwork;
        cardMana.text = card.mana.ToString();
        CardAttacak.text = card.attack.ToString();
        CardHealth.text = card.health.ToString();
    }

}
