using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour {
    public Team team;
    public Chessman chessman;
    public ChessPosition position;

    private SpriteRenderer spriteRenderer;

    void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() {
      Refresh();
    }

    public void Initialize(Team team, Chessman chessman, ChessPosition position) {
        this.team = team;
        this.chessman = chessman;
        this.position = position;

        gameObject.name = _GetChessPieceName();

        Refresh();
    }

    public void Refresh() {
        _RefreshChessPieceSprite();
        _RefreshChessPiecePosition();
    }

    private string _GetChessPieceName() {
        string teamName = team == Team.Black ? "Black" : "White";
        string chessmanName = _GetChessmanName(chessman);
        return teamName + " " + chessmanName;
    }

    private string _GetChessmanName(Chessman chessman) {
        switch (chessman) {
            case Chessman.Pawn: return "Pawn";
            case Chessman.Bishop: return "Bishop";
            case Chessman.Knight: return "Knight";
            case Chessman.Rook: return "Rook";
            case Chessman.Queen: return "Queen";
            case Chessman.King: return "King";
            default: throw new System.Exception();
        }
    }

    private void _RefreshChessPieceSprite() {
        spriteRenderer.sprite = Services.ChessSprites.GetChessmanSprite(chessman, team);
        spriteRenderer.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f));
    }

    private void _RefreshChessPiecePosition() {
        transform.position = position.GetWorldPosition();
    }
}
