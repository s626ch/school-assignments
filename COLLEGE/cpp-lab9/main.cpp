#include <iostream>
#include <string>
using namespace std;
// const
const string ATOZ("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz");
const string ALLNUMS("0123456789");
// proto
bool testPassword(string *usrPw);
size_t countLetters(string *usrPw, string alphaBet);
size_t countNumbers(string *usrPw, string zeroToNine);
int main() {
        string userPassword;
        string *pwPtr = &userPassword;
        cout << "Enter a password consisting of exactly 5 letters and 3 digits:" << endl;
        getline(cin, *pwPtr);
        if(pwPtr == nullptr){
                cout << "Error allocating memory." << endl;
                return -1;
        }
        if(testPassword(pwPtr)) {
                cout << "Please wait - your password is being verified" << endl;
        } else {
                cout << "Invalid password. Please enter a password with exactly 5 letters and 3 digits" << endl
                << "For example, my37RuN9 is valid" << endl;
        }
        return 0;
}
bool testPassword(string *usrPw) {
        if(countLetters(usrPw, ATOZ) == 5 && countNumbers(usrPw, ALLNUMS) == 3){
                return true;
        } else { return false; }
}
size_t countLetters(string *usrPw, string alphaBet) {
        size_t count = 0;
        for(string::size_type pos = 0;(pos = usrPw->find_first_of(alphaBet,pos))!=string::npos;++pos){
                ++count;
        }
        return count;
}
size_t countNumbers(string *usrPw, string zeroToNine) {
        size_t count = 0;
        for(string::size_type pos = 0;(pos = usrPw->find_first_of(zeroToNine,pos))!=string::npos;++pos){
                ++count;
        }
        return count;
}
