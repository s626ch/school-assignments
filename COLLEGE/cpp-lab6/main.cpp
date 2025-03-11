#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;
const int MAX_GRADES = 25;
int main(){
        int grade;
        int currGrade = 0;
        int grades[25];
        double totalGrades = 0;
        do {
                cout << "Please input a grade, or type -1 to stop:" << endl;
                cin >> grade;
                //cout << "grade: " << grade << endl;
                if(grade != -1){grades[currGrade]=grade;}
                //cout << "grades[currgrade]: " << grades[currGrade] << endl;}
                currGrade += 1;
                //cout << "currgrade: " << currGrade << endl;
                if(currGrade == 25){currGrade=26;} // ONLY take in 25 inputs
        } while (grade != -1 && currGrade != 26);
        currGrade -= 1;
        //cout << "ttl before for: " << totalGrades << endl;
        //cout << "currGrade before for: " << currGrade << endl;
        for(int i=0;i<currGrade;i++){
                //cout << "ttl before add: " << totalGrades << endl;
                totalGrades += grades[i];
                //cout << "ttl after add: " << totalGrades << endl;
        }
        double averageGrade = totalGrades/currGrade;
        if(isnan(averageGrade)){averageGrade = 0.0;} // isnan check with cmath for instant -1 entry
        // could've been done with an if but isnan is better for edge cases
        cout << setprecision(1) << showpoint << fixed << "The average of the " << currGrade << " grades read in is " << averageGrade << "." << endl;
        return 0;
}
