using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SashaHeyburgh_19336832_GADE5111_Exam
{
    public partial class Form2 : Form
    {
        string[,] arrGameMap;   //declaring 2D arrays
        string[,] arrUserGuesses;
        int randomRolls;    //declaring variables
        int numMinez;
        int mapWidth;
        int mapHeight;
        int actionsRemaining;
        int score;
        Boolean boolWin;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            boolWin = false;    //setting the win boolean to false
        }
        private void lblMinesweeper_Click(object sender, EventArgs e)
        {

        }

        public void startGame(int widthMin, int heightMin, int widthMax, int heightMax, int numMines)
        {
            mapWidth = randomRoll(widthMin, widthMax);  //setting the map width and height (minimum and maximum values) to random values
            mapHeight = randomRoll(heightMin, heightMax);
            arrGameMap = new string[mapWidth, mapHeight];     //filling the game map and user guesses 2D arrays with the map width and height
            arrUserGuesses = new string[mapWidth, mapHeight];
            score = 10;  //initializing the score variable to 0
            lblScore.Text = "Score: " + score;
            actionsRemaining = mapWidth * mapHeight;    //setting the remaining actions equal to the width of the map multiplied by the height of the map
            lblActions.Text = "Actions Remaining: " + actionsRemaining;
            initialiseMap(numMines);    //calling the initialiseMap method
            numMinez = numMines;
        }

        public int randomRoll(int minValue, int maxValue)
        {
            Random generator = new Random();
            randomRolls = generator.Next(minValue, maxValue + 1);   //randomizing a value between a given minimum and maximum value
            return randomRolls;          
        }


        public void initialiseMap(int mapMines)
        {
            for (int i = 0; i < mapWidth; i++)  //creating rows
            {
                for (int k = 0; k < mapHeight; k++)     //creating columns
                {
                    arrGameMap[i, k] = ". ";    //filling the game map 2D array with ". " per the rows and columns
                }
            } 
            fillMapWithMines(mapMines);     //calling the fillMapWithMines method
            redraw();   //calling the redraw method
        }

        public void fillMapWithMines(int mapMines)
        {
            int x;  //declaring variables
            int y;

            while (mapMines > 0)    //while the number of mines is more than zero do:
            {
                x = randomRoll(0, mapWidth - 1);    //assignming random values to x and y
                y = randomRoll(0, mapHeight - 1);

                if (arrGameMap[x, y] == ". ")   //if the x and y coordinates of the arrGameMap array are empty:
                {
                    placeMine(y, x, "x ");   //place "x"/mine
                    mapMines -= 1;  //subtract 1 from the number of mines
                }
                else
                {
                    //nothing
                }
            }
        }

        public void redraw()
        {
            lblMinesweeper.Text = "";   //clearing the label
            for (int i = 0; i < mapWidth; i++)  //rows
            {
                for (int k = 0; k < mapHeight; k++)     //columns
                {
                    if (arrGameMap[i, k] == "F "  )    //if the game map array does not have a mine at the given coordinates, then:
                    {
                        lblMinesweeper.Text = lblMinesweeper.Text + arrGameMap[i, k];  //filling the label with the dots for Minesweeper
                    }
                    else
                    {
                        if ((boolWin == false && arrGameMap[i, k] == "x " )|| (boolWin == false && arrGameMap[i, k] == ". "))   //if the win boolean is false, then:
                        {
                            lblMinesweeper.Text = lblMinesweeper.Text + ". ";   //displays dots where the user has not interacted
                    }
                        else
                    {
                            lblMinesweeper.Text = lblMinesweeper.Text + arrGameMap[i, k] + ' ';
                        }  
                        
                    } 
                    
                                
                }
                lblMinesweeper.Text = lblMinesweeper.Text + "\n";   //allowing the dots to be placed underneathe each other
            }
        }

        public void Guess()
        {
            int xPos;   //declaring variables
            int yPos;
            xPos = short.Parse(txtXPos.Text);  //assigning values to the X and Y positions
            yPos = short.Parse(txtYPos.Text);

            if (score < 1)  //if the user's score is lower than 1
            {
                MessageBox.Show("Guesses use up 1 point.");
            }
            else
            {
                score -= 1;     //subtract 1 from the score
                actionsRemaining -= 1;  //subtract 1 from the remaining actions
                lblScore.Text = "Score: " + score;  //Display the score
                lblActions.Text = "Actions Remaining: " + actionsRemaining;     //Display the actions remaining

                if (arrGameMap[xPos, yPos] == "x ")  //if the game map array at postion xPos and yPos are equal to "x" (it is a mine) then:
                {
                    lblInfo.Text = "";  //clearing the label
                    arrUserGuesses[xPos, yPos] = "F ";   //setting the xPos and yPos coordinates position of the user guesses array and the game map array to "F"
                    arrGameMap[xPos, yPos] = "F ";
                    score += 1;
                    redraw();   //calling the redraw method
                }
                else
                {
                    lblInfo.Text = "You have incorrectly flagged a mine.";
                }
            }

            Form1 Form1 = new Form1();
            if (numFlagged() == numMinez)  //if the result of the numFlagged method is equal to the number of mines, then:
            {
                boolWin = true;     //setting boolWin to true
                Gameover(boolWin);  //call the Gameover method
            }
        }

        public int numFlagged()
        {
            int iCount;     //declaring and initializing variable
            iCount = 0;

            for (int i = 0; i < mapWidth; i++)  //rows
            {
                for (int k = 0; k < mapHeight; k++)     //columns
                {
                    if (arrUserGuesses[i, k] == "F ")    //if the user guesses array at coordinates i and k are equal to "F", then:
                    {
                        iCount += 1;    //increase iCount variable by 1
                    }
                    else
                    {
                        //nothing
                    }                   
                }
            }
            return iCount;
        }

        public void placeMine(int xPosition, int yPosition, String character)
        {           
            arrGameMap[xPosition, yPosition] = character;   //assigning "x" to the arrGameMap coordinates
        }

        public void Gameover(bool boolWon)
        {
            if (boolWon)    //if the winning boolean is true then:
            {
                btnFlag.Enabled = false;    //diabling the buttons
                btnReveal.Enabled = false;
                RevealMap();    //calling the RevealMap method
                lblMinesweeper.Text = "Game Over";
            }
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            Guess();    //calling the Guess method
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            int xPos;   //declaring variables
            int yPos;
            xPos = Int16.Parse(txtXPos.Text);  //assigning values to the X and Y positions
            yPos = Int16.Parse(txtYPos.Text);
            if (RevealTile(xPos, yPos) == false)
            {
                redraw();   //calling the redraw method
            } 
        }

        public bool RevealTile(int xPosition, int yPosition)
        {
            if (CheckForMines(xPosition, yPosition) == 0)   //if the count from the CheckForMines method is 0 then:
            {
                arrGameMap[xPosition, yPosition] = "  ";    //there is no adjacent mines so reveal a blank tile
                return false;
            }
            else if (CheckForMines(xPosition, yPosition) == 9)  //if the count from the CheckForMines method is 9 then:
            {
                boolWin = true;     //the player revealed a mine, therefore the winning boolean is set to true
                Gameover(boolWin);  //calling the game over method
                return true;
            }
            else
            {
                arrGameMap[xPosition, yPosition] = CheckForMines(xPosition, yPosition).ToString();  //coordinates xPosition and yPosition of the game map array are set equal to the corresponding coordinate's returned integer value from the CheckForMines method
                return false;
            }
        }

        public void RevealMap()
        {
            for (int i = 0; i < mapWidth; i++)  //rows
            {
                for (int k = 0; k < mapHeight; k++)     //columns
                {
                    if (arrGameMap[i, k] == "F ")
                    {
                        arrGameMap[i, k] = "x ";    //replacing "F"'s with "x"s
                    }
                }
            }
            redraw();   //calling the redraw method
        }

        public int CheckForMines(int x, int y)  //method to receive x and y positions, check for mines and/or surrounding mines and returns 9 OR the number of surrounding mines
        {
            int count;  //variable declaration and initialization
            count = 0;
            //x -= 1;
            //y -= 1;

            if (arrGameMap[x, y] == "x ")
            {
                return 9;
            }

            if (x == 0 && y == 0)   //top left corner
            {
                if (arrGameMap[x + 1, y] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x + 1, y + 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x, y + 1] == "x ")
                {
                    count += 1;
                }
                return count;
            }

            if (x == mapWidth - 1 && y == 0)    //top right corner
            {
                if (arrGameMap[x - 1, y] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x - 1, y + 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x, y + 1] == "x ")
                {
                    count += 1;
                }
                return count;
            }

            if (x == 0 && y == mapHeight - 1)   //bottom left corner
            {
                if (arrGameMap[x + 1, y] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x + 1, y - 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x, y - 1] == "x ")
                {
                    count += 1;
                }
                return count;
            }

            if (x == mapWidth - 1 && y == mapHeight - 1)    //bottom right corner
            {
                if (arrGameMap[x - 1, y] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x - 1, y - 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x, y - 1] == "x ")
                {
                    count += 1;
                }
                return count;
            }

            if (y == 0)   //top row
            {
                if (arrGameMap[x + 1, y] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x - 1, y] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x, y + 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x + 1, y + 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x - 1, y + 1] == "x ")
                {
                    count += 1;
                }
                return count;
            }

            if (y == mapHeight - 1)    //bottom row
            {
                if (arrGameMap[x, y - 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x - 1, y] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x + 1, y] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x - 1, y - 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x + 1, y - 1] == "x ")
                {
                    count += 1;
                }
                return count;
            }

            if (x == 0)   //left column
            {
                if (arrGameMap[x, y - 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x, y + 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x + 1, y] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x + 1, y - 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x + 1, y + 1] == "x ")
                {
                    count += 1;
                }
                return count;
            }

            if (x == mapWidth - 1)    //right column
            {
                if (arrGameMap[x, y - 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x, y + 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x - 1, y] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x - 1, y - 1] == "x ")
                {
                    count += 1;
                }

                if (arrGameMap[x - 1, y + 1] == "x ")
                {
                    count += 1;
                }
                return count;
            }

            else
            {
                if (arrGameMap[x, y - 1] == "x ")    //above
                {
                    count += 1;
                }

                if (arrGameMap[x, y + 1] == "x ")    //below
                {
                    count += 1;
                }

                if (arrGameMap[x - 1, y] == "x ")    //to the left
                {
                    count += 1;
                }

                if (arrGameMap[x + 1, y] == "x ")    //to the right 
                {
                    count += 1;
                }

                if (arrGameMap[x - 1, y - 1] == "x ")    //top-left
                {
                    count += 1;
                }

                if (arrGameMap[x + 1, y - 1] == "x ")    //top-right
                {
                    count += 1;
                }

                if (arrGameMap[x - 1, y + 1] == "x ")    //bottom-left
                {
                    count += 1;
                }

                if (arrGameMap[x + 1, y + 1] == "x ")    //bottom-right
                {
                    count += 1;
                }
                return count;
            }
        }
    }
}
