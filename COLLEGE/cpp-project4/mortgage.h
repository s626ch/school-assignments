#ifndef MORTGAGE_H
#define MORTGAGE_H
// mortgage class
class Mortgage {
    private:
        // private vars
        double loanAmount;
        double annualRate;
        int years;
        double monthlyPayment;
        double totalPayback;
        // helper func to calculate payments
        void calculatePayment();
    public:
        // mortgage constructor
        Mortgage();
        // mutator functions
        void setLoanAmount(double amount);
        void setAnnualRate(double rate);
        void setYears(int numYears);
        // accessor functions
        double getMonthlyPayment() const;
        double getTotalPayback() const;
};
#endif // MORTGAGE_H
