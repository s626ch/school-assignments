#include <iostream>
#include <algorithm>
using namespace std;
const int MAX_SOLD = 10;
// more optimized search w/immediate return
int binarySearch(int tickets[], int size, int searchValue) {
        int first = 0;
        int last = size - 1;
        while (first <= last) {
                int middle = first + (last - first) / 2;
                if (tickets[middle] == searchValue) {
                        return middle; // return the index at which the target val is at
                } else if (tickets[middle] > searchValue) {
                        last = middle - 1;
                } else {
                        first = middle + 1;
                }
        }
        // return -1 if not found
        return -1;
}
int main(){
        int tickets[MAX_SOLD]={62484,77777,79422,85647,93121,13579,26791,26792,33445,55555};
        int winningNumber;
        do{
                cout << "Enter this week's winning number:" << endl;
                cin >> winningNumber;
                if(winningNumber<0 || winningNumber>99999){
                        cout << "Ticket numbers should be between 00000 and 99999." << endl;
                } else {
                        // stdlib sort is preferred over a manual implementation
                        sort(tickets,tickets+MAX_SOLD);
                        int result=binarySearch(tickets,MAX_SOLD,winningNumber);
                        if(result!=-1){
                                cout << "Congratulations! You've won!" << endl;
                        } else {
                                cout << "Sorry, better luck next time!" << endl;
                        }
                }
        } while(winningNumber<0 || winningNumber>99999);
        return 0;
}
