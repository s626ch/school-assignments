#include <iomanip>
#include <iostream>
#include <algorithm>
#include <string>
using namespace std;
const string MONTHS_YEAR[12] = {"January","February","March","April","May","June","July","August","September","October","November","December"};
const int AMNT_MONTHS = 12;
void calculateAverage(double arr[], int size);
void calculateHighest(double arr[], int size);
void calculateLowest(double arr[], int size);
int main(){
        double rainfallArr[12];
        double rainfallInput = 0;
        for(int i=0;i<12;i++){
                cout << "Enter rainfall for " << MONTHS_YEAR[i] << " in inches: ";
                cin >> rainfallInput;
                if(rainfallInput < 0){
                        cout << "You must enter a value >= 0" << endl;
                        i -= 1;
                } else {
                        rainfallArr[i] = rainfallInput;
                }
        }
        cout << endl;
        calculateAverage(rainfallArr, AMNT_MONTHS);
        calculateHighest(rainfallArr, AMNT_MONTHS);
        calculateLowest(rainfallArr, AMNT_MONTHS);
        return 0;
}

void calculateAverage(double arr[], int size) {
        double finalAverage = 0;
        for(int i=0;i<size;i++){
                finalAverage += arr[i];
        }
        finalAverage /= size;
        cout << fixed << showpoint << setprecision(2) << "The average rainfall per month is " << finalAverage << " inches." << endl;
}

void calculateHighest(double arr[], int size) {
        auto hiRainfall = max_element(arr, arr+size);
        int hiIndex = hiRainfall - arr;
        cout << MONTHS_YEAR[hiIndex] << " had the highest rainfall with " << *hiRainfall << " inches." << endl;
}

void calculateLowest(double arr[], int size) {
        auto loRainfall = min_element(arr, arr+size);
        int loIndex = loRainfall - arr;
        cout << MONTHS_YEAR[loIndex] << " had the lowest rainfall with " << *loRainfall << " inches." << endl;
}
