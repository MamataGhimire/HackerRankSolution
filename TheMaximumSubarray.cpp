#include <iostream>
using namespace std;
bool ifNegative(int num[],int size);
int maximum(int num[],int size);
void  subarray(int num[],int size);
void subsequence (int num[],int size);

int main() {
    
   // int num[]={-2,-3,-1,-4,-6};
   // int num[]={1,2,3,4};
   //int num[]={2,-1,2,3,4,-5};
    int num[]={-1,2,3,-4,5,10};
   
    
    int size=sizeof(num)/sizeof(num[0]);
    if(ifNegative(num,size))
    {
        int ans=maximum(num,size);
        cout<<ans<<" "<<ans;
        return 0;
    }
    ifNegative(num,size);
    subarray(num,size);
    subsequence(num,size);
    
    return 0;
}

  bool ifNegative(int num[],int size)
  {
     for(int i=0;i<size;i++)
     {
      if(num[i]<0)
      {
      }
      else
      {return false;}
     }
      return true;
  }
  int maximum(int num[],int size)
  {
      int max=num[0];
     for(int i=0;i<size;i++)
     {
         if(num[i]>max)
         {
             max=num[i];
         }
     }
     return max;
  }
  

 void subsequence (int num[],int size)
 {
     int maxi=0;
     for(int i=0;i<size;i++)
     {
           if(num[i]>0)
           {
               maxi=maxi+num[i];
           }
          
     }
      cout<<maxi;
 }
 
 void  subarray(int num[],int size)
 {
    
     int  mini=0;
     if(num[0]<num[size-1] && num[0]<0)
      {
         mini=num[0];
      }
     if(num[0]>num[size-1] && num[size-1]<0)
     {
        mini=num[size-1];
     }
     
     int mixi=0;
     for(int i=0;i<size;i++)
       {
         mixi=mixi+num[i];
       }
     
     mixi=mixi-mini;
     cout<<mixi<<" ";
 }
 
