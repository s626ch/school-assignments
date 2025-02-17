#include <iostream>
#include <iomanip>
using namespace std;
const double KM_IN_MI = 0.621;
const double MI_IN_KM = 1.61;
void dspMenu() {
        cout << "Please input one of the following options:" << endl
        << "1. Convert miles to kilometers" << endl
        << "2. Convert kilometers to miles" << endl
        << "3. Quit" << endl;
}
void cvMiToKm(double miles) {
        cout << fixed << setprecision(2) << miles << " miles = " << miles * MI_IN_KM << " kilometeres" << endl << endl;
}
void cvKmToMi(double kilms) {
        cout << fixed << setprecision(2) << kilms << " kilometers = " << kilms * KM_IN_MI << " miles" << endl << endl;
}
int main(){
        int mnChoice;
        double cnvInput;
        do {
                dspMenu();
                cin >> mnChoice;
                switch(mnChoice) {
                        case 1:
                                cout << "Please input the amount of miles to be converted: ";
                                cin >> cnvInput;
                                cvMiToKm(cnvInput);
                                break;
                        case 2:
                                cout << "Please input the amount of kilometers to be converted: ";
                                cin >> cnvInput;
                                cvKmToMi(cnvInput);
                                break;
                        case 3:
                                break;
                        default:
                                cout << "That is not a valid option." << endl << endl;
                                break;
                };
        } while (mnChoice != 3);
        return 0;
}
