#include <iostream>
#include <iomanip>
#include <algorithm>
#include <functional>
using namespace std;
double findSum(double*,int*);
double calAverage(double*,int*);
void sortSales(double*,int*);
void displaySales(double*,int*);
int main() {
        // this is an affront to god
        double *sales = nullptr;
        int months;
        int *monthsPtr = nullptr;
        monthsPtr = &months;
        // keep doing this until input isn't (somehow) a nullptr, or until it's between 1 and 12 (inclusive)
        do {
                cout << "Please input the number of monthly sales to be input: ";
                cin >> *monthsPtr;
                if(monthsPtr == nullptr || *monthsPtr <= 0 || *monthsPtr >= 13){
                        cout << "You must enter a value between 1 and 12 (inclusive). Please re-eneter." << endl;
                }
        } while (monthsPtr == nullptr || *monthsPtr <= 0 || *monthsPtr >= 13);
        sales = new double[*monthsPtr];
        // on the hopefully unlikely chance
        if(sales==nullptr){cout<<"Error allocating memory!"<<endl;return-1;}
        for(int m=0;m<months;m++){
                cout << "Please input the sales for month " << (m+1) << ": ";
                cin >> sales[m];
        }
        cout << fixed << setprecision(2) << "The total sales for the time period is $" << findSum(sales,monthsPtr) << endl
        << "The average month sale is $" << calAverage(sales,monthsPtr) << endl
        << "Sales in descending order:" << endl;
        sortSales(sales,monthsPtr);
        displaySales(sales,monthsPtr);
        // mem dealloc
        delete [] sales;
        sales = nullptr;
        return 0;
}
double findSum(double *salesData, int *monthsGiven) {
        double totalSales = 0;
        for(int m=0;m<*monthsGiven;m++){
                totalSales += *(salesData + m);
        }
        return totalSales;
}
double calAverage(double *salesData, int *monthsGiven) {
        double totalSales = 0;
        double averageSales = 0;
        for(int m=0;m<*monthsGiven;m++){
                totalSales += *(salesData + m);
        }
        averageSales = totalSales / static_cast<double>(*monthsGiven);
        return averageSales;
}
void sortSales(double *salesData, int *monthsGiven) {
        sort(salesData, salesData + *monthsGiven, greater<int>());
}
void displaySales(double *salesData, int *monthsGiven) {
        for(int m=0;m<*monthsGiven;m++){
                 cout << "$" << *(salesData + m) << endl;
        }   
}
