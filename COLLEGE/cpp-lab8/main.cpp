#include <iostream>
#include <iomanip>
#include <algorithm>
#include <functional>
using namespace std;
// function prototypes
void getNumberOfGrades(int *);
void displayGrades(int*,int);
int main() {
	int *grades = nullptr;
	int numOfGrades;       // the number of grades to be processed
	int *gradePtr = nullptr;
	int total = 0; // total of grades
	double average; // average of grades
	gradePtr = &numOfGrades;
	// get number of grades to be processed
	//numOfGrades = getNumberOfGrades();
	//getNumberOfGrades(&numOfGrades); // this is ok
	do {
		getNumberOfGrades(gradePtr);
		if(gradePtr == nullptr || *gradePtr <= 0){
			cout << "There must be at least one grade, please re-enter!" << endl;
		}
	} while (gradePtr == nullptr || *gradePtr <= 0);
	grades = new int[*gradePtr];
	if(grades==nullptr){
		cout << "Error allocating memory!" << endl;
		return -1;
	}
	// we have an array
	cout << "Enter the grade below" << endl;
	for(int c=0;c<numOfGrades;c++){
		cout << "Grade " << (c+1) << ": " << endl;
		// cin >> grades[c];
		cin >> *(grades + c);
		total += grades[c];
		// total += *(grades + count);
	}
	// actually do stuff
	average = total / static_cast<double>(numOfGrades);
	cout << setprecision(2) << fixed << showpoint << "Average grade is " << average << "%" << endl;
	// sort
	sort(grades, grades + numOfGrades, greater<int>());
	// display
	displayGrades(grades,numOfGrades);
	// dealloc mem
	delete [] grades;
	grades = nullptr;
	return 0;
}
//display grades
void displayGrades(int *grades, int numGrades){
	cout << "Grades in descending order: " << endl;
	for(int i=0;i<numGrades;i++){
		//one grade at a time
		//cout << grades[i] << endl;
		cout << *(grades + i) << endl;
	}
}
// get the number of grades to use ; int *numPtr
void getNumberOfGrades(int *number) {
	//int number = 0;
	cout << "How many grades will be processed "  << endl;
	cin >> *number; //store into addr ptd->number
	//return number;
}
