#include <cstdlib>
#include <string>
#include <iostream>
using namespace std;
class BookSale{
        private:
                // instance vars
                int quantity; // qty of book sold
                double price; // price of book
                string title; // title of book
                //static members, shared mem
                static int saleCount;
                static int booksSold;
                static double saleTotal;
                // private method
                double calculateExtPrice(){
                        // objSale.calculateExtPrice() NO!!!!!!!
                        //return quantity * price; // accessing priv vars
                        return getQuantity() * getPrice(); // accessing public methods of BookSale
                        // return getQuantity() * price;
                }
        public:
                // constructors
                // BookSale();
                BookSale(string, int, double); // overloaded constructor
                //anything public facing; gets and sets
                void setQuantity(int); // proto setter/mutator
                int getQuantity(); // proto to get quant -- getter/accessor
                void setPrice(double p){
                        if(p>=0) price = p; else { exit(-1); }
                } // inline func/method for this class
                double getPrice(){return price;}
                void setTitle(string t){title = t;}
                string getTitle(){return title;}
                // compute extended price
                double getExtendedPrice();
                //shared methods
                static int getSaleCount(){
                        return saleCount; //return static var
                }
                static int getBooksSold(){return booksSold;}
                static double getSaleTotal(){return saleTotal;}
};
