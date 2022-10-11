using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryManager : MonoBehaviour
{
    private const int cardCount = 4;
    private MemoryCard[] cards = new MemoryCard[cardCount];
    [SerializeField] private Texture[] frontTextures = new Texture[cardCount];
    [SerializeField] private Transform spritePositions;
    private Texture matchSprite;

    private bool correctCardPicked;

    public enum CardSprite
    {
        Hawaii,
        Palace,
        Grass,
        Yoshi,
        Avocado,
        Dice
    }

    private void CheckCard(MemoryCard card, CardSprite cardSprite)
    {
        if (card.frontTexture.name == cardSprite.ToString())
            correctCardPicked = true;
    }

    void Start()
    {
        for (int i = 0; i < cardCount; i++)
        {
            cards[i] = new MemoryCard(frontTextures[i], i + 1);

            foreach (Transform child in spritePositions)
            {
                child.GetComponent<RawImage>().texture = frontTextures[i];
                i++;
            }
        }
    }

    void Update()
    {

    }
}
