#include <iostream>
#include <iomanip>
#include <fstream>
using namespace std;
int main() {
	int drinkInput;
	int currPerson = 1;
	int coffeeCount = 0, teaCount = 0, cokeCount = 0, juiceCount = 0, otherCount = 0;
	bool validInput = false;
	ofstream resultsFile("results.txt");
	while(drinkInput!=-1) {
		// menu options, in an if to only print if input is not valid
		if(validInput == false){
			cout << "Menu:" << endl;
			cout << left << setw(15)
			<< "1. Coffee" << setw(15)
			<< "2. Tea" << setw(15)
			<< "3. Coke" << setw(15)
			<< "4. Juice" << setw(15)
			<< "5. Other" << endl;
		}
		// end menu options
		cout << "Please input the favorite beverage of person #" << currPerson << endl
		<< "Choose 1, 2, 3, 4, or 5 from the above menu, or -1 to exit the program." << endl;
		cin >> drinkInput;
		switch(drinkInput){
			case -1:
				if(resultsFile.is_open()){
					// first line header of file
					resultsFile << "The total number of people surveyed is "
					<< currPerson - 1 << ". The results are as follows:" << endl;
					// chart header
					resultsFile << left << setw(20) << "Beverage"
					<< setw(20) << "Number of Votes" << endl;
					// line of asterisks
					for(int i=0;i<40;i++){
						resultsFile << "*";
					}
					// statistics
					resultsFile << left << endl
					<< setw(20) << "Coffee" << setw(20) << coffeeCount << endl
					<< setw(20) << "Tea" << setw(20) << teaCount << endl
					<< setw(20) << "Coke" << setw(20) << cokeCount << endl
					<< setw(20) << "Juice" << setw(20) << juiceCount << endl
					<< setw(20) << "Other" << setw(20) << otherCount << endl;
					// close file
					resultsFile.close();
					cout << "Results written to results.txt" << endl;
				} else {
					// on the off chance something goes wrong
					cerr << "Error opening results.txt" << endl;
				}
				return 0;
			case 1:
				coffeeCount += 1;
				currPerson += 1;
				validInput = true;
				break;
			case 2:
				teaCount += 1;
				currPerson += 1;
				validInput = true;
				break;
			case 3:
				cokeCount += 1;
				currPerson += 1;
				validInput = true;
				break;
			case 4:
				juiceCount += 1;
				currPerson += 1;
				validInput = true;
				break;
			case 5:
				otherCount += 1;
				currPerson += 1;
				validInput = true;
				break;
			default:
				validInput = false;
				cout << "You must enter a valid menu item." << endl;
				break;
		}
	}
	return 0;
}
