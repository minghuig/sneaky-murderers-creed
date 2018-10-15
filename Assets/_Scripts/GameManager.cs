using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public ChessPiece chessPiecePrefab;

    public List<ChessPiece> pieces = new List<ChessPiece>();

    // MAIN ENTRY POINT
    void Start() {
        Services.InitializeServices();
        _setupGame(Team.White);
    }

    void Update() {
        // TODO: Handle player actions
    }

    private void _setupGame(Team playerTeam) {
        _placeBottomPieces(playerTeam);
        _placeTopPieces(playerTeam == Team.Black ? Team.White : Team.Black);
    }

    private void _placeBottomPieces(Team team) {
        _AddChessPiece(team, Chessman.Pawn, "A2");
        _AddChessPiece(team, Chessman.Pawn, "B2");
        _AddChessPiece(team, Chessman.Pawn, "C2");
        _AddChessPiece(team, Chessman.Pawn, "D2");
        _AddChessPiece(team, Chessman.Pawn, "E2");
        _AddChessPiece(team, Chessman.Pawn, "F2");
        _AddChessPiece(team, Chessman.Pawn, "G2");
        _AddChessPiece(team, Chessman.Pawn, "H2");

        _AddChessPiece(team, Chessman.Rook, "A1");
        _AddChessPiece(team, Chessman.Knight, "B1");
        _AddChessPiece(team, Chessman.Bishop, "C1");
        if (team == Team.White) {
            _AddChessPiece(team, Chessman.Queen, "D1");
            _AddChessPiece(team, Chessman.King, "E1");
        } else {
            _AddChessPiece(team, Chessman.King, "D1");
            _AddChessPiece(team, Chessman.Queen, "E1");
        }
        _AddChessPiece(team, Chessman.Bishop, "F1");
        _AddChessPiece(team, Chessman.Knight, "G1");
        _AddChessPiece(team, Chessman.Rook, "H1");
    }

    private void _placeTopPieces(Team team) {
        _AddChessPiece(team, Chessman.Pawn, "A7");
        _AddChessPiece(team, Chessman.Pawn, "B7");
        _AddChessPiece(team, Chessman.Pawn, "C7");
        _AddChessPiece(team, Chessman.Pawn, "D7");
        _AddChessPiece(team, Chessman.Pawn, "E7");
        _AddChessPiece(team, Chessman.Pawn, "F7");
        _AddChessPiece(team, Chessman.Pawn, "G7");
        _AddChessPiece(team, Chessman.Pawn, "H7");

        _AddChessPiece(team, Chessman.Rook, "A8");
        _AddChessPiece(team, Chessman.Knight, "B8");
        _AddChessPiece(team, Chessman.Bishop, "C8");
        if (team == Team.Black) {
            _AddChessPiece(team, Chessman.Queen, "D8");
            _AddChessPiece(team, Chessman.King, "E8");
        } else {
            _AddChessPiece(team, Chessman.King, "D8");
            _AddChessPiece(team, Chessman.Queen, "E8");
        }
        _AddChessPiece(team, Chessman.Bishop, "F8");
        _AddChessPiece(team, Chessman.Knight, "G8");
        _AddChessPiece(team, Chessman.Rook, "H8");
    }

    private void _AddChessPiece(Team team, Chessman chessman, string position) {
        ChessPiece chessPiece = Instantiate<ChessPiece>(chessPiecePrefab, Services.ChessBoardView.chessPiecesContainer);
        chessPiece.Initialize(team, chessman, new ChessPosition(position));

        pieces.Add(chessPiece);
    }
}
