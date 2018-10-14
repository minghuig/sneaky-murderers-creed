using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoardView : MonoBehaviour {
    public Transform bottomLeftSquareBottomLeft;
    public Transform bottomLeftSquareTopLeft;
    public Transform chessPiecesContainer;

    private Vector3 bottomLeftSquareCenter;

    private float squareSize;
    private float halfSquareSize;

    void Start() {
        _CalculateBoardSizeOffReferencePoints();
    }

    void Update() {
        _CalculateBoardSizeOffReferencePoints();
    }

    private void _CalculateBoardSizeOffReferencePoints() {
        squareSize = _CalculateSquareSize();
        halfSquareSize = squareSize / 2.0f;

        bottomLeftSquareCenter = _CalculateBottomLeftSquareCenter();
    }

    public Vector3 GetWorldPosition(ChessPosition chessPosition) {
        return new Vector3(
            bottomLeftSquareCenter.x + (chessPosition.column * squareSize),
            bottomLeftSquareCenter.y + (chessPosition.row * squareSize),
            0
        );
    }

    private float _CalculateSquareSize() {
        return bottomLeftSquareTopLeft.position.y - bottomLeftSquareBottomLeft.position.y;
    }

    private Vector3 _CalculateBottomLeftSquareCenter() {
        return new Vector3(
            bottomLeftSquareBottomLeft.position.x + halfSquareSize,
            bottomLeftSquareBottomLeft.position.y + halfSquareSize,
            0
        );
    }
}
