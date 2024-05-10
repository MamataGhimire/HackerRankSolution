#include <iostream>
using namespace std;
 
 int main()
 {
     int size;
     cout<<"enter size of array";
     cin>>size;
     
     int arr[size];
     
     for(int i=0;i<size;i++)
     {
         cin>>arr[i];
     }
     
      for(int i=0;i<size;i++)
  {
      int mini=i;
      for(int j=i;j<size;j++)
   {
      if(arr[j]<arr[mini])
      {
       mini=j;
      }

     }
   int swap=arr[mini];
      arr[mini]=arr[i];
      arr[i]=swap;
}
      
      for(int i=0;i<size;i++)
     {
         cout<<arr[i]<<" ";
     }
      
 }
