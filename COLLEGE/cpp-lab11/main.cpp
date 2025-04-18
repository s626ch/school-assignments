#include <iomanip>
#include <iostream>
#include "BookSale.h"
using namespace std;
//proto
void showSummary(int,int,double);
BookSale *getBookSale();
int main(){
        int choice;
        int saleCount = 0, booksSold = 0;
        double saleTotal = 0;
        BookSale *objSale = nullptr; // single sale
        do{
                cout<<"------------------------"<<endl
                <<    "1. Enter a new book sale"<<endl
                <<    "2. Show summary"<<endl
                <<    "3. Exit the program"<<endl<<endl
                <<    "Enter your choice: ";
                cin>>choice;
                switch(choice){
                        case 1:
                                objSale = getBookSale(); // collect info for sale
                                //saleCount++;
                                //booksSold = booksSold+objSale->getQuantity();
                                //saleTotal = saleTotal+objSale->getExtendedPrice();
                                //cout << "title: " << objSale->getTitle() << endl
                                //<< "ext price: " << objSale->getExtendedPrice();
                                break;
                        case 2:
                                //showSummary(saleCount,BooksSold,saleTotal);
                                //showSummary(BookSale::getSaleCount(), booksSold, saleTotal);
                                showSummary(BookSale::getSaleCount(),BookSale::getBooksSold(),BookSale::getSaleTotal());
                                break;
                }
        }while(choice!=3);
        return 0;
}
void showSummary(int count, int totalBooks, double totalPrice){
        cout<<setprecision(2)<<showpoint<<fixed
        << "------------------------" << endl
        << "Total Sales: " << count << endl
        << "Total Books Sold: " << totalBooks << endl
        << "Total Amount: $" << totalPrice << endl
        << "------------------------" << endl;
}
BookSale* getBookSale(){
        BookSale *objSale; // not an obj; pointer
        int quantity;
        string title;
        double price;
        // buffer clear
        cin.ignore();
        cout<<"------------------------"<<endl
        <<    "Enter book title:"<<endl;
        getline(cin, title);
        cout<<"Enter the quantity:"<<endl;
        cin>>quantity;
        cout<<"Enter the price:"<<endl;
        cin>>price;
        // create an instance of booksale
        //objSale = new BookSale;
        // set props
        // objSale->quantity = quantity;
        // CAN NOT do objSale.quantity = quantity;
        // (*objSale).setQuantity(quantity); // this is nightmare but it works
        // objSale->setQuantity(quantity); // better choice
        // objSale->setPrice(price);
        // objSale->setTitle(title);
        objSale = new BookSale(title, quantity, price); // call overload constructor from header/cpp
        return objSale;
}
