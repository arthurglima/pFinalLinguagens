using System;

class MainClass {

  public static void Main (string[] args) {
    string[,] tabuleiro = new string[8,8]; //Criando matriz para o tabuleiro.
    int i, j;
    for(i=0; i < 8; i++){ //Preenchendo tabuleiro com posições iniciais
      for(j=0; j < 8; j++){
        if(i == 0){
          switch(j){
            case 0:
              tabuleiro[i,j] = "T1";
              break;
            case 1:
              tabuleiro[i,j] = "C1";
              break;
            case 2:
              tabuleiro[i,j] = "B1";
              break;
            case 3:
              tabuleiro[i,j] = "D1";
              break;
            case 4:
              tabuleiro[i,j] = "R1";
              break;
            case 5:
              tabuleiro[i,j] = "B1";
              break;
            case 6:
              tabuleiro[i,j] = "C1";
              break;
            case 7:
              tabuleiro[i,j] = "T1";
              break;
          }
        }else if(i == 1)
          tabuleiro[i,j] = "P1";
        else if(i == 7){
          switch(j){
            case 0:
              tabuleiro[i,j] = "T2";
              break;
            case 1:
              tabuleiro[i,j] = "C2";
              break;
            case 2:
              tabuleiro[i,j] = "B2";
              break;
            case 3:
              tabuleiro[i,j] = "D2";
              break;
            case 4:
              tabuleiro[i,j] = "R2";
              break;
            case 5:
              tabuleiro[i,j] = "B2";
              break;
            case 6:
              tabuleiro[i,j] = "C2";
              break;
            case 7:
              tabuleiro[i,j] = "T2";
              break;
          }
        }
        else if(i == 6)
          tabuleiro[i,j] = "P2";
        else
          tabuleiro[i,j] = "--";
      }
    }
    Xadrez jogo = new Xadrez;

    jogo.imprimeTabuleiro(tabuleiro);
    Console.WriteLine ("");

    Console.WriteLine("");
  }
}



class Xadrez{





  public void imprimeTabuleiro(string[,] tabuleiro){
    int i;
    for(i=0; i < 8; i++){
      Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", 8-i, tabuleiro[i,0], tabuleiro[i,1], tabuleiro[i,2], tabuleiro[i,3], tabuleiro[i,4], tabuleiro[i,5], tabuleiro[i,6], tabuleiro[i,7]);
    }
    Console.WriteLine("  a  b  c  d  e  f  g  h");
  }
}