#include <iostream>
#include <iomanip>
using namespace std;
const double SHIRT_PRICE = 11.99;
// calc func to call later, takes in a percentage as a base 10 int and the amount of shirts from user input
void dscCalc(int dscPrc, int ttlShirts) {
        double perShirt, dscAmt;
        // switch/case to handle %
        switch(dscPrc) {
                // <=10 shirts, no discount needs calculated
                case 0:
                        perShirt = SHIRT_PRICE;
                        cout << fixed << setprecision(2) << "\nThe cost per shirt is $" << perShirt
                        <<  "\nThe total cost is $" << perShirt * ttlShirts << endl;
                        break;
                // literally anything else this calculates it based on input
                default:
                        dscAmt = (1.0*dscPrc) / 100;
                        perShirt = SHIRT_PRICE - (SHIRT_PRICE * dscAmt);
                        cout << fixed << setprecision(2) << "\nThe cost per shirt is $" << perShirt << endl;
                        cout << fixed << setprecision(1) << "You received a discount of " << static_cast<double>(dscPrc) << "%" << endl;
                        cout << fixed << setprecision(2) << "The total cost is $" << perShirt * ttlShirts << endl;
                        break;
        }
}
int main () {
        int amtShirts;
        cout << "How many shirts would you like?" << endl;
        cin >> amtShirts;
        // if/el for amounts
        if(amtShirts<0) {cout << "\nInvalid Input: Please enter a non-negative integer." << endl;}
        else if(amtShirts>=0 && amtShirts<=10){dscCalc(0, amtShirts);}
        else if(amtShirts>=11 && amtShirts<=25){dscCalc(10, amtShirts);}
        else if(amtShirts>=26 && amtShirts<=99){dscCalc(20, amtShirts);}
        else { dscCalc(30, amtShirts); }
        return 0;
}
