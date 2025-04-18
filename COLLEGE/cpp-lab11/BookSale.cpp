#include "BookSale.h"
BookSale::BookSale(string t, int qty, double p){
        // set/init instance vars, using private vars to change their vals, we can do this because we're in the booksale class
        // title = t;
        // quantity = qty;
        // price = p;
        // inside the class we can get to anything private or public
        setTitle(t);
        setQuantity(qty);
        setPrice(p);
        //accumu here
        saleCount++;
        //booksSold += qty;
        //booksSold += quantity;
        booksSold += getQuantity();
        saleTotal += (qty * p);
        //saleTotal = saleTotal + (qty * p);
        //saleTotal += (quantity * price);
        //saleTotal += (getQuantity() * getPrice());
}
void BookSale::setQuantity(int value){
        quantity = value; // change instance var
}
int BookSale::getQuantity(){
        return quantity; // just return the priv var
}
// ext price impl
double BookSale::getExtendedPrice(){
        //return getQuantity() * getPrice();
        return calculateExtPrice();
        // return quantity * price;
        // from within a method in the class, you can get to anything PRIVATE or PUBLIC
}
int BookSale::saleCount = 0;
int BookSale::booksSold = 0;
double BookSale::saleTotal = 0;
