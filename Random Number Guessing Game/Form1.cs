using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Guessing_Game
{
    public partial class Form1 : Form
    {
        //Declare Local variables
        int countGuess = 0;
        int guess;
        string resultMessage;
        int randomNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clear all fields (play again button is linked to this set of code)
            guessTextBox.Text = "";
            resultLabel.Text = "";
            guessCountLabel.Text = "";
            countGuess = 0;
            guessDisplayLabel.Text = "";

            Random randomGen = new Random();
            randomNumber = randomGen.Next(1, 101);
            MessageBox.Show("I'm thinking of a number between 1 and 100. Lets Guess it!", "", MessageBoxButtons.OK);
        }


        public void guessButton_Click(object sender, EventArgs e)
        {
            AcceptButton = guessButton; //allows user to press enter to guess

            // validate the entry in the "guess" text box and convert to int.
            if (int.TryParse(guessTextBox.Text, out guess))
            {// now if the value is successfully assigned, proceed with the logic.
                if(guess > 0 && guess <= 100)
                {
                    countGuess++;
                    if (guess > randomNumber)
                    {
                        resultMessage = "Too high, try again";
                        resultLabel.Text = resultMessage;
                        guessCountLabel.Text = countGuess.ToString();
                        guessDisplayLabel.Text = guess.ToString(); //Displays the current Guess allowing the guess text box to be cleared
                        guessTextBox.Text = "";
                        guessTextBox.Focus();

                    } // end instructions for guess greater than random number
                    else if (guess < randomNumber)
                    {
                        resultMessage = "Too low, try again";
                        resultLabel.Text = resultMessage;
                        guessCountLabel.Text = countGuess.ToString();
                        guessDisplayLabel.Text = guess.ToString();
                        guessTextBox.Text = "";
                        guessTextBox.Focus();

                    } // end instructions for guess less than random number
                    else if (guess == randomNumber)
                    {
                        if (countGuess < 5)
                        {
                            resultMessage = "Congratulations! You guessed the correct number (" + randomNumber + ") in only " + countGuess + " guesses!\nYou're a rockstar!";
                            resultLabel.Text = resultMessage;
                            guessCountLabel.Text = countGuess.ToString();
                            guessDisplayLabel.Text = guess.ToString();
                            guessTextBox.Text = "";
                            guessTextBox.Focus();
                        }
                        else if (countGuess > 5 && countGuess < 10)
                        {
                            resultMessage = "Congratulations! You guessed the correct number (" + randomNumber + ") in only " + countGuess + " guesses!\nYou're decent at this game!";
                            resultLabel.Text = resultMessage;
                            guessCountLabel.Text = countGuess.ToString();
                            guessDisplayLabel.Text = guess.ToString();
                            guessTextBox.Text = "";
                            guessTextBox.Focus();
                        }
                        else if (countGuess > 10)
                        {
                            resultMessage = "Congratulations! You guessed the correct number (" + randomNumber + "). It took you " + countGuess + " guesses though.\nYou're not very good at this game...";
                            resultLabel.Text = resultMessage;
                            guessCountLabel.Text = countGuess.ToString();
                            guessDisplayLabel.Text = guess.ToString();
                            guessTextBox.Text = "";
                            guessTextBox.Focus();
                        }

                    } // end instructions for correct answer guessed

                }  //end tested condition of number between 1 and 100
                else
                {
                    MessageBox.Show("Invalid Entry For Guess. Please enter an integer between 1 and 100", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }// end message for failed test to see if number is between 1 and 100.

            }// end of instructions for if guess is higher or lower than randomNumber

            else
            {
                MessageBox.Show("Invalid Entry For Guess. Please enter an integer between 1 and 100", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// end message for invalid guess entry: Data type
        }

        private void showAnswerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The answer is: " + randomNumber + " you freaking cheater pants");
        }

    }
}
