#include <iostream>
#include <iomanip>
using namespace std;
// prices
const double isTui = 3000, osTui = 4500, isRmBd = 2500, osRmBd = 3500;
int main () {
        // vars
        char tuition, rmbd;
        double tuiCost, rmbdCost;
        // get input
        cout << "Please input \"I\" if you are in-state or \"O\" if you are out-of-state:" << endl;
        cin.get(tuition);
        cin.ignore();
        cout << "\nPlease input \"Y\" if you require room and board and \"N\" if you do not:" <<endl;
        cin.get(rmbd);
        // switches for prices, and output, covers case
        switch(tuition) {
                case 'I':
                case 'i':
                        tuiCost = isTui;
                        rmbdCost = isRmBd;
                        break;
                case 'O':
                case 'o':
                        tuiCost = osTui;
                        rmbdCost = osRmBd;
                        break;
                default:
                        cout << "You did NOT enter an 'I' or an 'O', please try again." << endl;
                        return 1;
        }
        cout << "\nYour total bill for this semester is $";
        switch(rmbd) {
                case 'Y':
                case 'y':
                        cout << tuiCost + rmbdCost << endl;
                        break;
                case 'N':
                case 'n':
                        cout << tuiCost << endl;
                        break;
                default:
                        cout << "You did NOT enter a 'Y' or an 'N', please try again." << endl;
                        return 2;
        }
        return 0;
}
