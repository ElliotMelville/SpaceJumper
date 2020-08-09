using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceJumper
{
    public partial class SpaceJumper : Form
    {
        public SpaceJumper()
        {
            InitializeComponent();
            initialiseLabels();

            picAvatar.Image = picIPSFSample.Image;
            pnlSamples.Visible = false;
            lblYouWin.Visible = false;
            lblYouWin.Parent = picBoard;

            //dice preparations
            lblDiceLandedOn.Parent = picBoard;
            lblDiceLandedOn.Visible = false;
            tmrDiceShrink.Enabled = false;

            picAvatar.BringToFront();
            picAvatar.Location = pointCellCentreAvatar(0);
            picOpponent.Location = pointCellCentreOpponent(0);

            changePlayersTurnLabel();
        }

        //DEFINITIONS

        Color landedOnColor = Color.Maroon;

        //constants
        const int cellSize = 70;
        const int movementSpeed = 5;
        const int bounceNumber = 100;
        const bool forcedDice = false;

        //Dice variables
        int diceTickSpeed = 100;
        int diceLandedOn = 0;
        int diceSize = 400;
        bool isDiceLanded = false;
        int maxDiceNumber = 7;

        //Cell variables
        int avatarCurrentCell = 0;
        int opponentCurrentCell = 0;
        int avatarDesiredCell = 0;
        int opponentDesiredCell = 0;
        int bounceBack = 0;

        //Portals
        int[] Portals = 
        {
            /*up portals*/
            1,38,   4,14,   8,30,
            21,42,   28,76,
            50,67,
            71,92,
            80,99,

            /*down portals*/
            97,78,  94,56,
            88,24,
            62,18,
            48,26,
            36,6,
            32,10
        };
        int avatarSize = 50;
        int opponentSize = 50;
        bool isAvatarShrinking = false;
        bool isAvatarGrowing = false;
        bool isOpponentShrinking = false;
        bool isOpponentGrowing = false;
        int desiredPortalExit = 0;

        //Game Modes
        bool is2Player = true;
        bool is1Player = false;

        int maxDiceTickSpeed = 800;

        int opponentMovementSpeed = 5;

        bool isP1sTurn = true;

        int p1Moves = 0;
        int p2Moves = 0;

        //==================================================================

        //creates label numbering

        private void initialiseLabels()
        {
            int i = 1;
            while (i <= 100)
            {
                var cellNumber = new Label
                {
                    Name = "cellNumber" + i,
                    AutoSize = true,
                    Location = new Point(getCellLeft(i), getCellTop(i)),
                    Text = i.ToString(),
                    ForeColor = System.Drawing.Color.RoyalBlue,
                    BackColor = System.Drawing.Color.Black,
                    Font = new Font("SimSun", 10, FontStyle.Bold)
                };

                this.picBoard.Controls.Add(cellNumber);
                cellNumber.BringToFront();
                picAvatar.BringToFront();
                lblDiceLandedOn.BringToFront();
                lblYouWin.BringToFront();
                i++;
            }

        }

        //Dice rolling
        private void tmrDice_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            if (is2Player)
            {
                maxDiceTickSpeed = 800;
            }
            else if (is1Player)
            {
                maxDiceTickSpeed = 300;
            }

            if (isP1sTurn)
            {
                maxDiceTickSpeed = 800;
            }

            if(diceTickSpeed >= maxDiceTickSpeed)
            {
                isDiceLanded = true;
                tmrDiceShrink.Enabled = true;
            }

            //1, 7 (meaning 1 to 6)
            if (!forcedDice)
            {
                lblDice.Text = random.Next(1, maxDiceNumber).ToString();
                diceTickSpeed += 50;
            }
            else if (forcedDice)
            {
                lblDice.Text = 1.ToString();
                diceTickSpeed += 50;
            }

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            roll();
        }

        private void roll()
        {
            tmrDice.Enabled = true;
            diceTickSpeed = 100;
            tmrDice.Interval = 100;

            if (isP1sTurn)
            {
                lblDice.ForeColor = System.Drawing.Color.RoyalBlue;

                p1Moves++;
                lblP1Moves.Text = p1Moves.ToString();
            }
            else
            {
                lblDice.ForeColor = System.Drawing.Color.Firebrick;

                p2Moves++;
                lblP2Moves.Text = p2Moves.ToString();
            }

            lblDice.Font = new Font("SimSun", 18, FontStyle.Bold);

            isDiceLanded = false;
            btnRoll.Enabled = false;
        }

        private void tmrDiceShrink_Tick(object sender, EventArgs e)
        {
            tmrDice.Enabled = false;

            if (isDiceLanded)
            {
                lblDiceLandedOn.BringToFront();
                diceLandedOn = int.Parse(lblDice.Text);

                if(isP1sTurn)
                {
                    lblDiceLandedOn.ForeColor = System.Drawing.Color.RoyalBlue;
                    lblDice.ForeColor = System.Drawing.Color.MidnightBlue;
                }
                if (!isP1sTurn)
                {
                    lblDiceLandedOn.ForeColor = System.Drawing.Color.Maroon;
                    lblDice.ForeColor = System.Drawing.Color.Maroon;
                }

                lblDice.Font = new Font("SimSun", 20, FontStyle.Bold);
                lblDiceLandedOn.Text = diceLandedOn.ToString();

                lblDiceLandedOn.Visible = true;

               if(diceSize > 100)
               {
                   lblDiceLandedOn.Font = new Font("SimSun", diceSize, FontStyle.Bold);

                   diceSize -= 20;
               }
               else
               {
                    diceSize = 400;

                    lblDiceLandedOn.Visible = false;
                    isDiceLanded = false;

                    lblDiceLandedOn.Font = new Font("SimSun", 400, FontStyle.Bold);
                    tmrDiceShrink.Enabled = false;

                    //starting to move the avatar

                    if (isP1sTurn)
                    {
                        avatarDesiredCell = avatarCurrentCell + diceLandedOn;

                        if (avatarDesiredCell > bounceNumber)
                        {
                             bounceBack = avatarDesiredCell - bounceNumber;
                             avatarDesiredCell = bounceNumber;
                        }
                    }
                    else
                    {
                        opponentDesiredCell = opponentCurrentCell + diceLandedOn;

                        if (opponentDesiredCell > bounceNumber)
                        {
                            bounceBack = opponentDesiredCell - bounceNumber;
                            opponentDesiredCell = bounceNumber;
                        }
                    }
                    

                    tmrMoveCells.Enabled = true;
               }

            }
        }

        //avatar movement 

        private void tmrMoveCells_Tick(object sender, EventArgs e)
        {
            if (isP1sTurn)
            {
                moveAvatar();
            }
            else
            {
                moveOpponent();
            }

        }
       private void moveAvatar()
       {
            picAvatar.BringToFront();

            int nextCell;

            if(avatarCurrentCell == avatarDesiredCell)
            {
                tmrMoveCells.Enabled = false;
                avatarMoveCompleted();
                return;
            }

            if(avatarDesiredCell > avatarCurrentCell)
            {
                nextCell = avatarCurrentCell + 1;
            }
            else
            {
                nextCell = avatarCurrentCell - 1;
            }

            int desiredLeft = pointCellCentreAvatar(nextCell).X;
            int desiredTop = pointCellCentreAvatar(nextCell).Y;
            int currentLeft = picAvatar.Left;
            int currentTop = picAvatar.Top;

            if (desiredLeft == currentLeft && desiredTop == currentTop)
            {
                //avatar has reached it's desired cell
                avatarCurrentCell = nextCell;

                return;
            }

            if(desiredLeft == currentLeft)
            {
                //avatar is moving up
                picAvatar.Top -= movementSpeed;
            }
            else if(desiredLeft > currentLeft)
            {
                //avatar is moving right
                picAvatar.Left += movementSpeed;
            }
            else
            {
                //avatar is moving left
                picAvatar.Left -= movementSpeed;
            }
       }
        private void moveOpponent()
        {
            if (is2Player)
            {
                opponentMovementSpeed = 5;
            }
            else
            {
                opponentMovementSpeed = 10;
            }

            picOpponent.BringToFront();

            int nextCell;

            if (opponentCurrentCell == opponentDesiredCell)
            {
                tmrMoveCells.Enabled = false;
                opponentMoveCompleted();
                return;
            }

            if (opponentDesiredCell > opponentCurrentCell)
            {
                nextCell = opponentCurrentCell + 1;
            }
            else
            {
                nextCell = opponentCurrentCell - 1;
            }

            int desiredLeft = pointCellCentreOpponent(nextCell).X;
            int desiredTop = pointCellCentreOpponent(nextCell).Y;
            int currentLeft = picOpponent.Left;
            int currentTop = picOpponent.Top;

            if (desiredLeft == currentLeft && desiredTop == currentTop)
            {
                //avatar has reached it's desired cell
                opponentCurrentCell = nextCell;

                return;
            }

            if (desiredLeft == currentLeft)
            {
                //avatar is moving up
                picOpponent.Top -= opponentMovementSpeed;
            }
            else if (desiredLeft > currentLeft)
            {
                //avatar is moving right
                picOpponent.Left += opponentMovementSpeed;
            }
            else
            {
                //avatar is moving left
                picOpponent.Left -= opponentMovementSpeed;
            }
        }
        private void avatarMoveCompleted()
        {
            int i = 0;
            int portalEntry = 0;
            int portalExit = 0;

            isP1sTurn = false;
            changePlayersTurnLabel();

            if (avatarCurrentCell == bounceNumber && bounceBack != 0)
            {
                avatarDesiredCell = bounceNumber - bounceBack;
                tmrMoveCells.Enabled = true;
                avatarCurrentCell = bounceNumber;

                bounceBack = 0;
            }
            else if(avatarCurrentCell == bounceNumber && bounceBack == 0)
            {
                avatarGameWon();
            }

            while (i <= 28)
            {
                portalEntry = (Portals[i]);
                portalExit = (Portals[i + 1]);

                if(avatarCurrentCell == portalEntry)
                {
                    desiredPortalExit = portalExit;
                    tmrPlayerShrink.Enabled = true;

                    isAvatarShrinking = true;

                    break;
                }

                i += 2;
            }

            if (is2Player)
            {
                btnRoll.Enabled = true;
            }
            else
            {
                roll();
            }

        }
        private void opponentMoveCompleted()
        {
            int i = 0;
            int portalEntry = 0;
            int portalExit = 0;

            isP1sTurn = true;
            changePlayersTurnLabel();
            
            if (opponentCurrentCell == bounceNumber && bounceBack != 0)
            {
                opponentDesiredCell = bounceNumber - bounceBack;
                tmrMoveCells.Enabled = true;
                opponentCurrentCell = bounceNumber;

                bounceBack = 0;
            }
            else if (opponentCurrentCell == bounceNumber && bounceBack == 0)
            {
                opponentGameWon();
            }

            while (i <= 28)
            {
                portalEntry = (Portals[i]);
                portalExit = (Portals[i + 1]);

                if (opponentCurrentCell == portalEntry)
                {
                    desiredPortalExit = portalExit;
                    tmrPlayerShrink.Enabled = true;

                    if (isP1sTurn)
                    {
                        isOpponentShrinking = true;
                    }
                    else
                    {
                        isOpponentShrinking = true;
                    }


                    break;
                }

                i += 2;
            }

            btnRoll.Enabled = true;
        }
        private void tmrPlayerShrink_Tick(object sender, EventArgs e)
        {
            picAvatar.Width = avatarSize;
            picAvatar.Height = avatarSize;

            picOpponent.Width = opponentSize;
            picOpponent.Height = opponentSize;

            //moving avatar
            if (isAvatarShrinking)
            {
                if (avatarSize > 10)
                {
                    avatarSize -= 10;
                    picAvatar.Left += 5;
                    picAvatar.Top += 5;
                }
                else
                {
                    isAvatarShrinking = false;
                    isAvatarGrowing = true;

                    picAvatar.Location = pointCellCentreAvatar(desiredPortalExit);
                    avatarCurrentCell = desiredPortalExit;

                }
            }
            else if (isAvatarGrowing)
            {
                if (avatarSize < 50)
                {
                    avatarSize += 10;
                    picAvatar.Left -= 5;
                    picAvatar.Top -= 5;
                }
                else
                {
                    isAvatarGrowing = false;
                    tmrPlayerShrink.Enabled = false;
                }
            }
            //moving opponent
            if (isOpponentShrinking)
            {
                if (opponentSize > 10)
                {
                    opponentSize -= 10;
                    picOpponent.Left += 5;
                    picOpponent.Top += 5;
                }
                else
                {
                    isOpponentShrinking = false;
                    isOpponentGrowing = true;

                    picOpponent.Location = pointCellCentreOpponent(desiredPortalExit);
                    opponentCurrentCell = desiredPortalExit;

                }
            }
            else if (isOpponentGrowing)
            {
                if (opponentSize < 50)
                {
                    opponentSize += 10;
                    picOpponent.Left -= 5;
                    picOpponent.Top -= 5;
                }
                else
                {
                    isOpponentGrowing = false;
                    tmrPlayerShrink.Enabled = false;
                }
            }

        }

        private void avatarGameWon()
        {
            if(picAvatar.Image == picIPSFSample.Image)
            {
                lblYouWin.Text = "IPSF WINS!";
            }
            else
            {
                lblYouWin.Text = "BSSF WINS!";
            }
            lblYouWin.BringToFront();
            lblYouWin.Visible = true;
        }
        private void opponentGameWon()
        {
            if (picOpponent.Image == picIPSFSample.Image)
            {
                lblYouWin.Text = "IPSF WINS!";
            }
            else
            {
                lblYouWin.Text = "BSSF WINS!";
            }
            lblYouWin.BringToFront();
            lblYouWin.Visible = true;
        }

        //GETTING TOP AND LEFT OF CELLS
        private int getCellLeft(int cell)
        {
            int cellPos = 0;

            //cell is counting from zero
            if(((cell - 1) / 10) % 2 == 0)
            {
                //even rows going left to right
                cellPos = (cell - 1) % 10;
            }
            else
            {
                //odd rows going right to left
                cellPos = 9 - ((cell - 1) % 10);
            } 

            return (cellPos * cellSize);
        }

        private int getCellTop(int cell)
        {
            return ((9 - ((cell - 1) / 10)) * cellSize);
        }

        //not cell centre, cell centre including avatar's top left corner
        private Point pointCellCentreAvatar(int cell)
        {
            int xPos = getCellLeft(cell) + (cellSize / 2) - (picAvatar.Width / 2);
            int yPos = getCellTop(cell) + (cellSize / 2) - (picAvatar.Width / 2) + picBoard.Top;

            return new Point (xPos, yPos);
        }

        private Point pointCellCentreOpponent(int cell)
        {
            int xPos = getCellLeft(cell) + (cellSize / 2) - (picOpponent.Width / 2);
            int yPos = getCellTop(cell) + (cellSize / 2) - (picOpponent.Width / 2) + picBoard.Top;

            return new Point(xPos, yPos);
        }

        private int getEndCellNumber(int currentCell)
        {
            if(currentCell % 10 == 0)
            {
                return currentCell;
            }

            return ((currentCell - 1) / 10) * 10 + 10;
        }

        //PLAYERS TURN
        private void changePlayersTurnLabel()
        {
            if(isP1sTurn)
            {
                if (is2Player)
                {
                    lblPlayersTurn.Text = "P1's TURN";
                    lblPlayersTurn.ForeColor = System.Drawing.Color.RoyalBlue;
                }
                else
                {
                    lblPlayersTurn.Text = "YOUR TURN";
                    lblPlayersTurn.ForeColor = System.Drawing.Color.RoyalBlue;
                }
            }

            if(!isP1sTurn)
            {
                if (is2Player)
                {
                    lblPlayersTurn.Text = "P2's TURN";
                    lblPlayersTurn.ForeColor = System.Drawing.Color.Maroon;
                }
                else
                {
                    lblPlayersTurn.Text = "BOT's TURN";
                    lblPlayersTurn.ForeColor = System.Drawing.Color.Maroon;
                }

            }
        }

        //MENU
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //6-sided
        private void sidedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRoll.Image = picD6Sample.Image;

            maxDiceNumber = 7;
        }

        //8-sided
        private void sidedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnRoll.Image = picD8Sample.Image;

            maxDiceNumber = 9;
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is2Player = true;
            is1Player = true;

            lblGameMode.Text = "2-PLAYER";
        }

        private void playeragainsntBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is1Player = true;
            is2Player = false;

            lblGameMode.Text = "1-PLAYER";
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
