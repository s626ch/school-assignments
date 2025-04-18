#include <iostream>
#include <iomanip>
#include "mortgage.h"
using namespace std;
// func prototypes
void showPayment(const Mortgage* mortgage);
Mortgage getLoan();
// main func
int main() {
    int choice;
    do {
        cout<<"------------------------"<<endl
            <<"1. Enter a new loan"<<endl
            <<"2. Exit program"<<endl
            <<"Enter your choice: ";
        cin>>choice;
        // switch for menu, w/default fallback for any invalid input
        switch(choice) {
            case 1: {
                Mortgage loan = getLoan();
                showPayment(&loan);
                break;
            }
            case 2:
                break;
            default:
                cout<<"Invalid choice. Please enter 1 or 2."<<endl;
        }
    }while(choice!=2);
    return 0;
}
// func to display payment info
void showPayment(const Mortgage* mortgage) {
    cout<<fixed<<setprecision(2)
        <<"========================"<<endl
        <<"Monthly Payment: $"<<mortgage->getMonthlyPayment()<<endl
        <<"Total Pay Back: $"<<mortgage->getTotalPayback()<<endl
        <<"========================"<<endl;
}
// func to get loan info
Mortgage getLoan() {
    Mortgage loan;
    double amount, rate;
    int years;
    cout<<"Enter the amount of the loan: ";
    cin>>amount;
    while(amount<=0){
        cout<<"Loan amount must be greater than 0. Please re-enter: ";
        cin>>amount;
    }
    loan.setLoanAmount(amount);
    cout<<"Enter the annual interest rate in decimal form (example .075): ";
    cin>>rate;
    while(rate<0){
        cout<<"Interest rate must be greater than 0. Please re-enter: ";
        cin>>rate;
    }
    loan.setAnnualRate(rate);
    cout<<"Enter the length of the loan in years: ";
    cin>>years;
    while(years<=0||years>30){
        cout<<"Years must be greater than 0 and less than 30. Please re-enter: ";
        cin>>years;
    }
    loan.setYears(years);
    return loan;
}
