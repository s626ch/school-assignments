#include <iomanip>
#include <iostream>
using namespace std;
int main() {
        double prColonial = 85.00, prClassical = 127.75, prModern = 57.50;
        int amtColonial, amtClassical, amtModern;
        cout << "Please input the number of American Colonial chairs sold: " << endl;
        cin >> amtColonial;
        cout << "Please input the number of Modern chairs sold: " << endl;
        cin >> amtModern;
        cout << "Please input the number of French Classical chairs sold: " << endl;
        cin >> amtClassical;
        // calculations
        double ttlColonial = prColonial * amtColonial, ttlModern = prModern * amtModern, ttlClassical = prClassical * amtClassical;
        double ttlAll = ttlColonial + ttlModern + ttlClassical;
        double avgSale = ttlAll / (amtColonial + amtClassical + amtModern);
        // final output -------------------------
        cout << fixed << setprecision(2)
        << "The total sales of American Colonial chairs is $" << ttlColonial << endl
        << "The total sales of Modern chairs is $" << ttlModern << endl
        << "The total sales of French Classical chairs is $" << ttlClassical << endl
        << "The total sales of all chairs is $" << ttlAll << endl                                    
        << "The average chair sale is $" << avgSale << endl;
        return 0;
}
