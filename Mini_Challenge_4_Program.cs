// Daniel Decoito
// 10-18-2022
// Mini Challenge 4 "Greater than or Less than"
// I need to get user input in the form of ints and I need to compare those
// Values and see if they are greater than or equal to
// Peer Reviewd by: Pedro Castaneda - The program works as it should. Overall its great work! 
// 
Console.Clear();
int firstnum = 2;
int secondnum = 3;
string terminateGame = "Dan";
string userInput;
bool boolOne = false;
bool boolTwo = false;

//-----------------------ParseMethood----------------------------
static bool ParseBool(string userInput)
{
    bool result = int.TryParse(userInput, out int numOut) ? result = true : result = false;
    return result;
}
//-----------------------Methood 2-------------------------------
static string mathStuffs(int firstnum, int secondnum)
{
if(firstnum > secondnum){
   return $"{firstnum} is greater than {secondnum} \n{secondnum}  is less than {firstnum} ";
} 
else if ( firstnum == secondnum)
{
   return "The numbers are equal to one another.";
}
else
{
    return $"{firstnum} is less than {secondnum} \n{secondnum} greater than {firstnum}";
    
}
}
//-------------------------------Start---------------------------------------
while (terminateGame != "")
{
Console.WriteLine("Hell0 user lets play the greater than or less than game. ");
do
{
Console.WriteLine("Please pick the first number");
userInput = Console.ReadLine();
boolOne = ParseBool(userInput);
} while (boolOne == false);
firstnum = int.Parse(userInput);
do
{
Console.WriteLine("Please pick the second number");
userInput = Console.ReadLine();
boolTwo = ParseBool(userInput);
} while (boolTwo == false);
secondnum = int.Parse(userInput);
Console.Clear();
Console.WriteLine(mathStuffs(firstnum,secondnum));
Console.WriteLine("***----****----***\nWould you like to play again?\nEnter any key to play again\nOr just press Enter to quit");
terminateGame = Console.ReadLine();
boolOne = false;
boolOne = false;
}


