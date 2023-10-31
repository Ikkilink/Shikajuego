using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoardManager : MonoBehaviour
{
    public bool azulWin = false;
    public bool rojoWin = false;
    //public GameObject azulpanel;
    //public GameObject rojoPanel;
    public float tiempopanel;
    public float contadorvictoriasazul = 0f;
    public float contadorvictoriasrojo = 0f;

    Board1 board1;
    Board2 board2;
    Board3 board3;
    Board4 board4;
    Board5 board5;
    Board6 board6;
    Board7 board7;
    Board8 board8;
    Board9 board9;
    Board10 board10;
    Board11 board11;
    Board12 board12;
    Board13 board13;
    Board14 board14;
    Board15 board15;
    Board16 board16;
    Board17 board17;
    Board18 board18;
    Board19 board19;
    Board20 board20;
    Board21 board21;
    Board22 board22;
    Board23 board23;
    Board24 board24;
    Board25 board25;


    void Start()
    {
        board1 = FindFirstObjectByType<Board1>();
        board2 = FindFirstObjectByType<Board2>();
        board3 = FindFirstObjectByType<Board3>();
        board4 = FindFirstObjectByType<Board4>();
        board5 = FindFirstObjectByType<Board5>();
        board6 = FindFirstObjectByType<Board6>();
        board7 = FindFirstObjectByType<Board7>();
        board8 = FindFirstObjectByType<Board8>();
        board9 = FindFirstObjectByType<Board9>();
        board10 = FindFirstObjectByType<Board10>();
        board11 = FindFirstObjectByType<Board11>();
        board12 = FindFirstObjectByType<Board12>();
        board13 = FindFirstObjectByType<Board13>();
        board14 = FindFirstObjectByType<Board14>();
        board15 = FindFirstObjectByType<Board15>();
        board16 = FindFirstObjectByType<Board16>();
        board17 = FindFirstObjectByType<Board17>();
        board18 = FindFirstObjectByType<Board18>();
        board19 = FindFirstObjectByType<Board19>();
        board20 = FindFirstObjectByType<Board20>();
        board21 = FindFirstObjectByType<Board21>();
        board22 = FindFirstObjectByType<Board22>();
        board23 = FindFirstObjectByType<Board23>();
        board24 = FindFirstObjectByType<Board24>();
        board25 = FindFirstObjectByType<Board25>();


    }

    void Update()
    {
        HorizontalWinBlue();
        HorizontalWinRed();
        VerticalWinBlue();
        VerticalWinRed();
        LeftRightWinBlue();
        LeftRightWinRed();
        RightLeftWinBlue();
        RightLeftWinRed();

        if (azulWin == true)
        {
            SceneManager.LoadScene("Ganador2");
            Debug.Log("Sapatabibelaluchasigue");

        }
        if (rojoWin == true)
        {
            SceneManager.LoadScene("Ganador1");
            Debug.Log("Gananlosrojos");
        }
    }

    void HorizontalWinBlue()
    {
        if (board1.azul1 == true && board2.azul2 == true && board3.azul3 == true && board4.azul4 == true)
        {
            azulWin = true;
        }

        else if (board2.azul2 == true && board3.azul3 == true && board4.azul4 == true && board5.azul5 == true)
        {
            azulWin = true;
        }

        else if (board6.azul6 == true && board7.azul7 == true && board8.azul8 == true && board9.azul9 == true)
        {
            azulWin = true;
        }

        else if (board7.azul7 == true && board8.azul8 == true && board9.azul9 == true && board10.azul10 == true)
        {
            azulWin = true;
        }

        else if (board11.azul11 == true && board12.azul12 == true && board13.azul13 == true && board14.azul14 == true)
        {
            azulWin = true;
        }

        else if (board15.azul15 == true && board12.azul12 == true && board13.azul13 == true && board14.azul14 == true)
        {
            azulWin = true;
        }

        else if (board16.azul16 == true && board17.azul17 == true && board18.azul18 == true && board19.azul19 == true)
        {
            azulWin = true;
        }

        else if (board20.azul20 == true && board17.azul17 == true && board18.azul18 == true && board19.azul19 == true)
        {
            azulWin = true;
        }

        else if (board21.azul21 == true && board22.azul22 == true && board23.azul23 == true && board24.azul24 == true)
        {
            azulWin = true;
        }

        else if (board25.azul25 == true && board22.azul22 == true && board23.azul23 == true && board24.azul24 == true)
        {
            azulWin = true;
        }
    }

    void HorizontalWinRed()
    {
        if (board1.rojo1 == true && board2.rojo2 == true && board3.rojo3 == true && board4.rojo4 == true)
        {
            rojoWin = true;
        }

        else if (board2.rojo2 == true && board3.rojo3 == true && board4.rojo4 == true && board5.rojo5 == true)
        {
            rojoWin = true;
        }

        else if (board6.rojo6 == true && board7.rojo7 == true && board8.rojo8 == true && board9.rojo9 == true)
        {
            rojoWin = true;
        }

        else if (board7.rojo7 == true && board8.rojo8 == true && board9.rojo9 == true && board10.rojo10 == true)
        {
            rojoWin = true;
        }

        else if (board11.rojo11 == true && board12.rojo12 == true && board13.rojo13 == true && board14.rojo14 == true)
        {
            rojoWin = true;
        }

        else if (board15.rojo15 == true && board12.rojo12 == true && board13.rojo13 == true && board14.rojo14 == true)
        {
            rojoWin = true;
        }

        else if (board16.rojo16 == true && board17.rojo17 == true && board18.rojo18 == true && board19.rojo19 == true)
        {
            rojoWin = true;
        }

        else if (board20.rojo20 == true && board17.rojo17 == true && board18.rojo18 == true && board19.rojo19 == true)
        {
            rojoWin = true;
        }

        else if (board21.rojo21 == true && board22.rojo22 == true && board23.rojo23 == true && board24.rojo24 == true)
        {
            rojoWin = true;
        }

        else if (board25.rojo25 == true && board22.rojo22 == true && board23.rojo23 == true && board24.rojo24 == true)
        {
            rojoWin = true;
        }
    }

    void VerticalWinBlue()
    {
        if (board1.azul1 == true && board6.azul6 == true && board11.azul11 == true && board16.azul16 == true)
        {
            azulWin = true;
        }

        else if (board21.azul21 == true && board6.azul6 == true && board11.azul11 == true && board16.azul16 == true)
        {
            azulWin = true;
        }

        else if (board2.azul2 == true && board7.azul7 == true && board12.azul12 == true && board17.azul17 == true)
        {
            azulWin = true;
        }

        else if (board22.azul22 == true && board7.azul7 == true && board12.azul12 == true && board17.azul17 == true)
        {
            azulWin = true;
        }

        else if (board3.azul3 == true && board8.azul8 == true && board13.azul13 == true && board18.azul18 == true)
        {
            azulWin = true;
        }

        else if (board23.azul23 == true && board8.azul8 == true && board13.azul13 == true && board18.azul18 == true)
        {
            azulWin = true;
        }

        else if (board4.azul4 == true && board9.azul9 == true && board14.azul14 == true && board19.azul19 == true)
        {
            azulWin = true;
        }

        else if (board24.azul24 == true && board9.azul9 == true && board14.azul14 == true && board19.azul19 == true)
        {
            azulWin = true;
        }

        else if (board5.azul5 == true && board10.azul10 == true && board15.azul15 == true && board20.azul20 == true)
        {
            azulWin = true;
        }

        else if (board25.azul25 == true && board10.azul10 == true && board15.azul15 == true && board20.azul20 == true)
        {
            azulWin = true;
        }
    }

    void VerticalWinRed()
    {
        if (board1.rojo1 == true && board6.rojo6 == true && board11.rojo11 == true && board16.rojo16 == true)
        {
            rojoWin = true;
        }

        else if (board21.rojo21 == true && board6.rojo6 == true && board11.rojo11 == true && board16.rojo16 == true)
        {
            rojoWin = true;
        }

        else if (board2.rojo2 == true && board7.rojo7 == true && board12.rojo12 == true && board17.rojo17 == true)
        {
            rojoWin = true;
        }

        else if (board22.rojo22 == true && board7.rojo7 == true && board12.rojo12 == true && board17.rojo17 == true)
        {
            rojoWin = true;
        }

        else if (board3.rojo3 == true && board8.rojo8 == true && board13.rojo13 == true && board18.rojo18 == true)
        {
            rojoWin = true;
        }

        else if (board23.rojo23 == true && board8.rojo8 == true && board13.rojo13 == true && board18.rojo18 == true)
        {
            rojoWin = true;
        }

        else if (board4.rojo4 == true && board9.rojo9 == true && board14.rojo14 == true && board19.rojo19 == true)
        {
            rojoWin = true;
        }

        else if (board24.rojo24 == true && board9.rojo9 == true && board14.rojo14 == true && board19.rojo19 == true)
        {
            rojoWin = true;
        }

        else if (board5.rojo5 == true && board10.rojo10 == true && board15.rojo15 == true && board20.rojo20 == true)
        {
            rojoWin = true;
        }

        else if (board25.rojo25 == true && board10.rojo10 == true && board15.rojo15 == true && board20.rojo20 == true)
        {
            rojoWin = true;
        }
    }

    void LeftRightWinBlue()
    {
        if (board6.azul6 == true && board12.azul12 == true && board18.azul18 == true && board22.azul22 == true)
        {
            azulWin = true;
        }

        else if (board1.azul1 == true && board7.azul7 == true && board13.azul13 == true && board19.azul19 == true)
        {
            azulWin = true;
        }

        else if (board7.azul7 == true && board13.azul13 == true && board19.azul19 == true && board25.azul25 == true)
        {
            azulWin = true;
        }

        else if (board2.azul2 == true && board8.azul8 == true && board14.azul14 == true && board20.azul20 == true)
        {
            azulWin = true;
        }
    }

    void LeftRightWinRed()
    {
        if (board6.rojo6 == true && board12.rojo12 == true && board18.rojo18 == true && board22.rojo22 == true)
        {
            rojoWin = true;
        }

        else if (board1.rojo1 == true && board7.rojo7 == true && board13.rojo13 == true && board19.rojo19 == true)
        {
            rojoWin = true;
        }

        else if (board7.rojo7 == true && board13.rojo13 == true && board19.rojo19 == true && board25.rojo25 == true)
        {
            rojoWin = true;
        }

        else if (board2.rojo2 == true && board8.rojo8 == true && board14.rojo14 == true && board20.rojo20 == true)
        {
            rojoWin = true;
        }
    }

    void RightLeftWinBlue()
    {
        if (board10.azul10 == true && board14.azul14 == true && board18.azul18 == true && board22.azul22 == true)
        {
            azulWin = true;
        }

        else if (board5.azul5 == true && board9.azul9 == true && board13.azul13 == true && board17.azul17 == true)
        {
            azulWin = true;
        }

        else if (board21.azul21 == true && board9.azul9 == true && board13.azul13 == true && board17.azul17 == true)
        {
            azulWin = true;
        }

        else if (board4.azul4 == true && board8.azul8 == true && board12.azul12 == true && board16.azul16 == true)
        {
            azulWin = true;
        }
    }

    void RightLeftWinRed()
    {
        if (board10.rojo10 == true && board14.rojo14 == true && board18.rojo18 == true && board22.rojo22 == true)
        {
            rojoWin = true;
        }

        else if (board5.rojo5 == true && board9.rojo9 == true && board13.rojo13 == true && board17.rojo17 == true)
        {
            rojoWin = true;
        }

        else if (board21.rojo21 == true && board9.rojo9 == true && board13.rojo13 == true && board17.rojo17 == true)
        {
            rojoWin = true;
        }

        else if (board4.rojo4 == true && board8.rojo8 == true && board12.rojo12 == true && board16.rojo16 == true)
        {
            rojoWin = true;
        }
    }
}