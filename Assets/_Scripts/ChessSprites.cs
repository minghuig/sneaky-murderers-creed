using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessSprites : MonoBehaviour {
    public Sprite whitePawnSprite;
    public Sprite blackPawnSprite;

    public Sprite whiteBishopSprite;
    public Sprite blackBishopSprite;

    public Sprite whiteKnightSprite;
    public Sprite blackKnightSprite;

    public Sprite whiteRookSprite;
    public Sprite blackRookSprite;

    public Sprite whiteQueenSprite;
    public Sprite blackQueenSprite;

    public Sprite whiteKingSprite;
    public Sprite blackKingSprite;

    public Sprite GetChessmanSprite(Chessman chessman, Team team) {
        switch (chessman) {
            case Chessman.Pawn:
                return team == Team.Black ? blackPawnSprite : whitePawnSprite;
            case Chessman.Bishop:
                return team == Team.Black ? blackBishopSprite : whiteBishopSprite;
            case Chessman.Knight:
                return team == Team.Black ? blackKnightSprite : whiteKnightSprite;
            case Chessman.Rook:
                return team == Team.Black ? blackRookSprite : whiteRookSprite;
            case Chessman.Queen:
                return team == Team.Black ? blackQueenSprite : whiteQueenSprite;
            case Chessman.King:
                return team == Team.Black ? blackKingSprite : whiteKingSprite;

            default: throw new System.Exception();
        }
    }
}
