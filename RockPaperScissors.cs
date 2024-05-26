using System;
public class Program{
public static void Main(string[] args){
//data and Objects declarations
//data stored for the game state
string userInput = "";
int compChoice = -1;
int playerChoice = -1;
bool playing = true;
//metadata about the game
int tie = 0;
int win = 0;
int loss = 0;
//CONSTANTS to increase readability
int ROCK = 0;
int PAPER = 1;
int SCISSORS = 2;
//Game Logic
while(playing){
Random rand = new Random();
//Computer needs to pick a random int value (0-2)
compChoice = rand.Next(0,3);//0.0-> 2.9999999 -> typecast -> 0-2
//Prompt the user to pick a value
Console.WriteLine("Pick Rock, Paper or Scissors");
//Read and store the players response
userInput = Console.ReadLine();
//Evaluate the players response and assign correct int value
if(userInput.Equals("Rock")){playerChoice = ROCK;}
else if(userInput.Equals("Paper")){playerChoice = PAPER;}
else if(userInput.Equals("Scissors")){playerChoice = SCISSORS;}
//Evaluate the the game result (win/loss/tie)
//increment correct value based on the result
if(compChoice == ROCK){
if(playerChoice == ROCK){
Console.WriteLine("Tie, you and the comp both chose rock!");
tie++;
}
else if(playerChoice == PAPER){
Console.WriteLine("You won, your paper covers the computers rock!");
win++;
}
else if(playerChoice == SCISSORS){
Console.WriteLine("You lost, the computers rock crushes your scissors!");
loss++;
}
}
else if(compChoice == PAPER){
if(playerChoice == ROCK){
Console.WriteLine("You lost, the computer's paper covers your rock!");
loss++;
}
else if(playerChoice == PAPER){
Console.WriteLine("Tie, you and the comp both chose paper!");
tie++;
}
else if(playerChoice == SCISSORS){
Console.WriteLine("You Win, your scissors cut the computers paper!");
win++;
}
}
else if(compChoice == SCISSORS){
if(playerChoice == ROCK){
Console.WriteLine("You Win, your rock crushed the computers scissors!");
win++;
}
else if(playerChoice == PAPER){
Console.WriteLine("You Lost, the computers scissors cut your paper");
loss++;
}
else if(playerChoice == SCISSORS){
Console.WriteLine("Tie, you and the comp both chose scissors!");
tie++;
}
}
//Ask user if they want to keep playing
Console.WriteLine("Would you like to play again? (y/n)");
//read and store response
userInput = Console.ReadLine();
//evaluate response
if(userInput.Equals("n")){
playing = false;
}
else{
compChoice = -1;
playerChoice = -1;
}
}
//Thank user
Console.WriteLine("Thanks for playing Rock, Paper, Scissors");
//Print stats
Console.WriteLine("You played a total of " + (win + loss + tie) + " games!");
Console.WriteLine("You won: " + win + " games");
Console.WriteLine("You lost: " + loss + " games");
Console.WriteLine("You tied: " + tie + " games");
}
}