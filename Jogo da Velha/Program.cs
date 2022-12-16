string[,] array = new string[9,18];
bool vitoria = false;
int[] jogadas = new int[9];
int[] jogador1 = new int[5];
int[] jogador2 = new int[5];
int rodada = 0;
int pos = 0;
bool checagem;

iniciar(array);



while(vitoria == false)
{

    Console.Clear();
    desenho(array);
    Console.WriteLine("Para jogar digite a posição desejada e aperte ENTER!");
    Console.WriteLine("Vez do jogador 1:  ");
    jogador1[pos] = Convert.ToInt32(Console.ReadLine());
    checagem = libera(jogadas, pos, jogador1, jogador2, rodada);
    while (checagem == false)
    {
        Console.WriteLine("Jogada invalida, jogue novamente: ");
        jogador1[pos] = Convert.ToInt32(Console.ReadLine());
        checagem = libera(jogadas, pos, jogador1, jogador2, rodada);
    }
    jogadas[rodada] = jogador1[pos];
    salva1(jogador1, array, pos );
    rodada++;
    Console.Clear();
    desenho(array);
    vitoria = final1(vitoria, array);
    if (vitoria == true)
    {
        Console.WriteLine("Jogador 1 ganhou!");
    }
    if (rodada == 9 && vitoria == false)
    {
        vitoria = true;
        Console.WriteLine("O jogo ficou empatado, VELHA!");
    }

    if (vitoria == false)
    {


    Console.WriteLine("Vez do jogador 2: ");
    jogador2[pos] = Convert.ToInt32(Console.ReadLine());
    checagem = libera(jogadas, pos, jogador1, jogador2, rodada);
    while (checagem == false)
    {
        Console.WriteLine("Jogada invalida, jogue novamente: ");
        jogador2[pos] = Convert.ToInt32(Console.ReadLine());
        checagem = libera(jogadas, pos, jogador1, jogador2, rodada);
    }
    jogadas[rodada] = jogador2[pos];
    salva2(jogador2, array, pos);
    rodada++;
    Console.Clear();
    desenho(array);
    pos++;
    
    vitoria = final2(vitoria, array);
    if (vitoria == true)
        {
            Console.WriteLine("Jogador 2 ganhou!");
        }
    }
}


Console.WriteLine("Final de jogo!");


static bool final2(bool vitoria, string[,] array)
{

    if (array[1, 2] == "O" && array[1, 8] == "O" && array[1, 14] == "O")
    {
        return true;
    }
    else if (array[4, 2] == "O" && array[4, 8] == "O" && array[4, 14] == "O")
    {
        return true;
    }
    else if (array[7, 2] == "O" && array[7, 8] == "O" && array[7, 14] == "O")
    {
        return true;
    }
    else if (array[1, 2] == "O" && array[4, 2] == "O" && array[7, 2] == "O")
    {
        return true;
    }
    else if (array[1, 8] == "O" && array[4, 8] == "O" && array[7, 8] == "O")
    {
        return true;
    }
    else if (array[1, 14] == "O" && array[4, 14] == "O" && array[7, 14] == "O")
    {
        return true;
    }
    else if (array[1, 2] == "O" && array[4, 8] == "O" && array[7, 14] == "O")
    {
        return true;
    }
    else if (array[1, 14] == "O" && array[4, 8] == "O" && array[7, 2] == "O")
    {
        return true;
    }
    else
    {

        return false;
    }

}
static bool final1(bool vitoria, string[,] array)
{
    if (array[1, 2] == "X" && array[1, 8] == "X" && array[1, 14] == "X")
        {
            return true;
        }
    else if (array[4, 2] == "X" && array[4, 8] == "X" && array[4, 14] == "X")
        {
            return true;
        }
    else if (array[7, 2] == "X" && array[7, 8] == "X" && array[7, 14] == "X")
    {
        return true;
    }
    else if (array[1, 2] == "X" && array[4, 2] == "X" && array[7, 2] == "X")
    {
        return true;
    }
    else if (array[1, 8] == "X" && array[4, 8] == "X" && array[7, 8] == "X")
    {
        return true;
    }
    else if (array[1, 14] == "X" && array[4, 14] == "X" && array[7, 14] == "X")
    {
        return true;
    }
    else if (array[1, 2] == "X" && array[4, 8] == "X" && array[7, 14] == "X")
    {
        return true;
    }
    else if (array[1, 14] == "X" && array[4, 8] == "X" && array[7, 2] == "X")
    {
        return true;
    }
    else 
    { 
        return false;
    }

} 

static void salva2(int[] jogador2, string[,] array, int pos)
{
    if (jogador2[pos] == 1)
    {
        array[1, 2] = "O";
    }
    else if (jogador2[pos] == 2)
    {
        array[1, 8] = "O";
    }
    else if (jogador2[pos] == 3)
    {
        array[1, 14] = "O";
    }
    else if (jogador2[pos] == 4)
    {
        array[4, 2] = "O";
    }
    else if (jogador2[pos] == 5)
    {
        array[4, 8] = "O";
    }
    else if (jogador2[pos] == 6)
    {
        array[4, 14] = "O";
    }
    else if (jogador2[pos] == 7)
    {
        array[7, 2] = "O";
    }
    else if (jogador2[pos] == 8)
    {
        array[7, 8] = "O";
    }
    else if (jogador2[pos] == 9)
    {
        array[7, 14] = "O";
    }

}
static void salva1(int[] jogador1, string[,] array, int pos)
{
 if(jogador1[pos] == 1)
    {
        array[1, 2] = "X";
    }
    else if(jogador1[pos] == 2)
    {
        array[1, 8] = "X";
    }
    else if(jogador1[pos] == 3)
    {
        array[1, 14] = "X";
    }
    else if (jogador1[pos] == 4)
    {
        array[4, 2] = "X";
    }
    else if (jogador1[pos] == 5)
    {
        array[4, 8] = "X";
    }
    else if (jogador1[pos] == 6)
    {
        array[4, 14] = "X";
    }
    else if (jogador1[pos] == 7)
    {
        array[7, 2] = "X";
    }
    else if (jogador1[pos] == 8)
    {
        array[7, 8] = "X";
    }
    else if (jogador1[pos] == 9)
    {
        array[7, 14] = "X";
    }

}


static bool libera (int[] jogadas, int pos, int[] jogador1, int[] jogador2, int rodada)
{
    bool check = true;
    if(rodada % 2 == 0)
    {
        if(jogador1[pos] > 9 || jogador1[pos] < 1)
        {
            check = false;
        }
        for(int i =0; i < 9; i++)
        {
            if (jogador1[pos] == jogadas[i])
            {
                check = false;
            }
        }
    }
    else
    {
        if (jogador2[pos] > 9 || jogador2[pos] < 1)
        {
            check = false;
        }
        for (int i = 0; i < 9; i++)
        {
            if (jogador2[pos] == jogadas[i])
            {
                check = false;
            }
        }
    }

            return check;

}



static void iniciar(string[,] array)
{
    for (int l = 0; l < 9; l++)
    {

        for (int c = 0; c < 17; c++)
        {
            if (c == 5 || c == 11)
            {
                array[l, c] = "|";
            }

            else if (l == 2 || l == 5)
            {
                array[l, c] = "_";
            }
            else
            {
                array[l, c] = " ";
            }

           
        }
    }
}
static void desenho(string[,] array)
{
    for (int l = 0; l < 9; l++)
    {

        for (int c = 0; c <= 17; c++)
        {
            if (c == 17)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(array[l, c]);
            }
        }

    }

}



//     |     |
//  1  |  2  |  3  
//_____|_____|_____
//     |     |
//  4  |  5  |  6
//_____|_____|_____
//     |     |
//  7  |  8  |  9
//     |     |
//
//123
//456
//789
//
//
//
