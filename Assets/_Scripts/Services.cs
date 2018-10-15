using UnityEngine;

public static class Services {
    public static ChessSprites ChessSprites;
    public static ChessBoardView ChessBoardView;

    public static void InitializeServices() {
        ChessSprites = Services._GetTaggedComponent<ChessSprites>("ChessSprites");
        ChessBoardView = Services._GetTaggedComponent<ChessBoardView>("ChessBoardView");
    }

    private static T _GetTaggedComponent<T>(string tag) {
        return GameObject.FindGameObjectWithTag(tag).GetComponent<T>();
    }
}