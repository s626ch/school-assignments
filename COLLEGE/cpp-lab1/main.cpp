#include <iostream>
#include <string>
using namespace std;
const string MY_NAME = "????"; // use double quotes
const string NICK_NAME = "Stitch";
int main()
{
  char desiredGrade = 'A'; // desired grade for this class
  string favoriteDrink = "Tea"; // favorite drink
  int numberOfComputers = 16; // i have a problem                      
  int numberOfConsoles = 24; // ...
  int numberOfPhones = 8; // :)  
  double priceOfDevice = 2000; // how much did the most expensive device cost you?
  // Fill in the code to do the following:
  // Assign a value to favoriteDrink
  // Assign a value to your desiredGrade
  // Assign a value to numberOfDevices
  // Assign a value to priceOfDevice
  // Fill in the blanks of the following:
  cout << "My name is " << MY_NAME << ", but a lot of people call me " << NICK_NAME << endl << endl;
  cout << "My preferred drink is " << favoriteDrink << endl;
  cout << "I would like to get an " << desiredGrade << " in ???? ????" << endl;
  cout << "I currently have ... uh..." << endl << numberOfComputers << " computers, " << numberOfConsoles << " consoles, and " << numberOfPhones << " phones" << endl 
    << " and the most expensive one cost around " << priceOfDevice
    << ".\n";
  return 0;
}
