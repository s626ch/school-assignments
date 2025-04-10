#include <iostream>
#include <iomanip>
#include <algorithm>
#include <string>
using namespace std;
struct Student{
        string name;
        double gpa;
};

void getNumOfStu(int*);
void getStuData(Student*, int);
void displayResults(const Student*, int, const Student&, double);
Student findTopStu(const Student*, int);
double calcAvgGPA(const Student*, int);

int main(){
        int numStu = 0;
        Student* students = nullptr;
        do{
                getNumOfStu(&numStu);
                if(numStu<=0){cout<<"There must be at least one student, please re-enter!"<<endl;}
        } while(numStu<=0);
        students = new Student[numStu];
        if(students == nullptr){
                cout<<"Error allocating memory!"<<endl;
                return -1;
        }
        getStuData(students,numStu);
        Student topStu = findTopStu(students,numStu);
        double avgGPA = calcAvgGPA(students,numStu);
        displayResults(students,numStu,topStu,avgGPA);
        delete[] students;
        students = nullptr;
        return 0;
}

void getNumOfStu(int* num){
        cout<<"Students in the class: "<<endl;
        cin>>*num;
}
void getStuData(Student* students, int numStu){
        for(int i=0;i<numStu;i++){
                cout<<"------------------------------"<<endl
                <<"STUDENT #"<<(i+1)<<endl
                <<"------------------------------"<<endl
                <<"Enter the student's name: "<<endl;
                cin.ignore();
                getline(cin, students[i].name);
                cout<<"Enter the student's GPA: "<<endl;
                cin>>students[i].gpa;
        }
}
Student findTopStu(const Student* students, int numStu){
        Student top = students[0];
        for(int i=1;i<numStu;i++){
                if(students[i].gpa>top.gpa){
                        top=students[i];
                }
        }
        return top;
}
double calcAvgGPA(const Student* students, int numStu){
        double total = 0.0;
        for(int i=0;i<numStu;i++){
                total+=students[i].gpa;
        }
        return total / numStu;
}
void displayResults(const Student* students, int numStu, const Student& topStu, double avgGPA){
        cout<<"------------------------------"<<endl
        <<"Top Student: "<<topStu.name<<" GPA: "<<fixed<<setprecision(2)<<topStu.gpa<<endl
        <<"------------------------------"<<endl
        <<"Average Student GPA: "<<avgGPA<<endl;
}
