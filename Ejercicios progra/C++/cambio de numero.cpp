#include <iostream>
using namespace std;
int main (){
	int a;
	int b;
	cout<<"ingresae un numero: ";
	cin>>a;
	b=((a%10)*10);
	a=a/10;
	a=a+b;
	cout<<a;
	
	
	
	
	
	return 0;
}
