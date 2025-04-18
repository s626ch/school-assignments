#include "mortgage.h"
#include <cmath>
// mortgage constructor
Mortgage::Mortgage() {
    loanAmount = 0;
    annualRate = 0;
    years = 0;
    monthlyPayment = 0;
    totalPayback = 0;
}
// mutator functions
void Mortgage::setLoanAmount(double amount) {
    if(amount>0) {
        loanAmount = amount;
        calculatePayment();
    }
}
// mutator func to set annual rate
void Mortgage::setAnnualRate(double rate) {
    if(rate>=0) {
        annualRate = rate;
        calculatePayment();
    }
}
// mutator func to set years
void Mortgage::setYears(int numYears) {
    if(numYears>0&&numYears<=30) {
        years = numYears;
        calculatePayment();
    }
}
// helper func to calculate payments
void Mortgage::calculatePayment() {
    if(loanAmount>0&&annualRate>=0&&years>0&&years<=30) {
        double monthlyRate = annualRate/12;
        double term = pow(1+monthlyRate, 12*years);
        monthlyPayment = (loanAmount*monthlyRate*term)/(term-1);
        totalPayback = monthlyPayment*12*years;
    }
}
// accessor funcs to get monthly payment and total payback
double Mortgage::getMonthlyPayment() const {return monthlyPayment;}
double Mortgage::getTotalPayback() const {return totalPayback;}
